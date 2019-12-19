#include "main.h"

#include <TlHelp32.h>
#include <Shlwapi.h>

using namespace ProcessHelper;

// Injects proxy dll and loads DLL via mono
bool ProcessHelper::InjectDLL(int processId, std::string dllPath, std::string dllNamespace, std::string proxyPath, void* proxyBase)
{
	std::vector<char> proxyFile = UInjectLoader::FileReadAllBytes(UInjectLoader::ToWString(proxyPath));

	typedef void(__cdecl* LoadAssembly_t)(const char* assemblyPath);
	LoadAssembly_t loadAssembly = (LoadAssembly_t)((intptr)proxyBase + (intptr)UInjectLoader::GetProcAddressEx(&proxyFile[0], "LoadAssembly"));

	HANDLE handle = OpenProcess(PROCESS_ALL_ACCESS, FALSE, processId);

	if (handle == INVALID_HANDLE_VALUE)
	{
		return false;
	}

	LPVOID pDllStruct = VirtualAllocEx(handle, NULL, sizeof(LPVOID) * 2, MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);
	LPVOID pDllPath = VirtualAllocEx(handle, NULL, dllPath.length(), MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);
	LPVOID pDllNamespace = VirtualAllocEx(handle, NULL, dllNamespace.length(), MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);

	if (pDllStruct == NULL || pDllPath == NULL || pDllNamespace == NULL)
	{
		CloseHandle(handle);
		return false;
	}

	if (WriteProcessMemory(handle, pDllStruct, &pDllPath, sizeof(LPVOID), NULL) == ERROR)
	{
		CloseHandle(handle);
		return false;
	}

	if (WriteProcessMemory(handle, (LPVOID)((intptr)pDllStruct + sizeof(LPVOID)), &pDllNamespace, sizeof(LPVOID), NULL) == ERROR)
	{
		CloseHandle(handle);
		return false;
	}

	if (WriteProcessMemory(handle, pDllPath, dllPath.data(), dllPath.length(), NULL) == ERROR)
	{
		CloseHandle(handle);
		return false;
	}

	if (WriteProcessMemory(handle, pDllNamespace, dllNamespace.data(), dllNamespace.length(), NULL) == ERROR)
	{
		CloseHandle(handle);
		return false;
	}

	if (CreateRemoteThread(handle, NULL, NULL, (LPTHREAD_START_ROUTINE)loadAssembly, pDllStruct, NULL, NULL) == ERROR)
	{
		CloseHandle(handle);
		return false;
	}

	CloseHandle(handle);

	return true;
}

