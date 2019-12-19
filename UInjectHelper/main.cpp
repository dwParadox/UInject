// dllmain.cpp : Defines the entry point for the DLL application.
#include "main.h"

extern "C"
{
	__declspec(dllexport) void* GetLoadAddress(void* proxyVector, void* proxyBase)
	{
		return (void*)((intptr)proxyBase + (intptr)UInjectLoader::GetProcAddressEx(&proxyVector, "LoadAssembly"));
	}

	__declspec(dllexport) void* GetFileVector(char* proxyPath) 
	{
		MessageBox(0, proxyPath, "Success!", MB_ICONINFORMATION);
		return static_cast<void*>(UInjectLoader::FileReadAllBytes(UInjectLoader::ToWString(std::string(proxyPath))).data());
	}

	__declspec(dllexport) bool LoadDll(int processId, char* dllPath, char* dllNamespace, char* proxyPath, __int64 proxyBase) {
		return ProcessHelper::InjectDLL(processId, std::string(dllPath), std::string(dllNamespace), std::string(proxyPath), (void*)proxyBase);
	}

	__declspec(dllexport) void CheckConnection()
	{
		MessageBox(0, "Hello from DLL!", "Success!", MB_ICONINFORMATION);
	}
}