#pragma once

#ifdef _WIN64
typedef uint64_t intptr;
#else
typedef uint32_t intptr;
#endif

namespace UInjectLoader {
	std::string ToString(std::wstring);
	std::string ToString(System::String^);

	std::wstring ToWString(std::string);

	System::String^ ToSysString(std::string str);

	std::string CurrentPath();

	void* GetProcAddressEx(void* pModuleBase, std::string procName);

	std::vector<char> FileReadAllBytes(const std::wstring& name);
}