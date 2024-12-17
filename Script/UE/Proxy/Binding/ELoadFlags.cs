namespace Script.CoreUObject
{
	public enum ELoadFlags : int
	{
		LOAD_None = 0,
		LOAD_Async = 1,
		LOAD_NoWarn = 2,
		LOAD_EditorOnly = 4,
		LOAD_ResolvingDeferredExports = 8,
		LOAD_Verify = 16,
		LOAD_NoVerify = 128,
		LOAD_IsVerifying = 256,
		LOAD_DisableDependencyPreloading = 4096,
		LOAD_Quiet = 8192,
		LOAD_FindIfFail = 16384,
		LOAD_MemoryReader = 32768,
		LOAD_NoRedirects = 65536,
		LOAD_ForDiff = 131072,
		LOAD_PackageForPIE = 524288,
		LOAD_DeferDependencyLoads = 1048576,
		LOAD_ForFileDiff = 2097152,
		LOAD_DisableCompileOnLoad = 4194304
	}
}