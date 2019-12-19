#pragma once
namespace ProcessHelper {
	bool InjectDLL(int processId, std::string dllPath, std::string dllNamespace, std::string proxyPath, void* proxyBase);
}