using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.FlibPatchParserHelper")]
	public partial class UFlibPatchParserHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.FlibPatchParserHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void ReloadShaderbytecode()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ReloadShaderbytecode);
			}
		}

		public static bool LoadShaderbytecode(FString LibraryName, FString LibraryDir)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LibraryName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LibraryDir?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadShaderbytecode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString HashStringWithSHA1(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __HashStringWithSHA1, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetProjectName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetProjectName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetProjectIniFiles(FString InProjectDir, FString InPlatformName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InProjectDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetProjectIniFiles, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static FString GetProjectFilePath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetProjectFilePath, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool GetPakFileInfo(FString InFile, ref FPakFileInfo OutFileInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutFileInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPakFileInfo, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFileInfo = *(FPakFileInfo*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetIniConfigs(FString InSearchDir, FString InPlatformName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSearchDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetIniConfigs, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetEngineConfigs(FString InPlatformName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEngineConfigs, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetEnabledPluginConfigs(FString InPlatformName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEnabledPluginConfigs, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static bool GetCookedShaderBytecodeFiles(FString InProjectAbsDir, FString InProjectName, FString InPlatformName, bool InGalobalBytecode, bool InProjectBytecode, ref TArray<FString> OutFiles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = InProjectAbsDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InProjectName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = InGalobalBytecode;

				*(bool*)(__InBuffer + 25) = InProjectBytecode;

				*(nint*)(__InBuffer + 26) = OutFiles?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetCookedShaderBytecodeFiles, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFiles = *(TArray<FString>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetCookedGlobalShaderCacheFiles(FString InProjectDir, FString InPlatformName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InProjectDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCookedGlobalShaderCacheFiles, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static bool GetCookedAssetRegistryFiles(FString InProjectAbsDir, FString InProjectName, FString InPlatformName, ref FString OutFiles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InProjectAbsDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InProjectName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPlatformName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutFiles?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetCookedAssetRegistryFiles, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFiles = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetAvailableMaps(FString GameName, bool IncludeEngineMaps, bool IncludePluginMaps, bool Sorted)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = GameName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = IncludeEngineMaps;

				*(bool*)(__InBuffer + 9) = IncludePluginMaps;

				*(bool*)(__InBuffer + 10) = Sorted;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAvailableMaps, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static FPlatformExternFiles GetAllExFilesByPlatform(FPlatformExternAssets InPlatformConf, bool InGeneratedHash, EHashCalculator HashCalculator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InPlatformConf?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InGeneratedHash;

				*(int*)(__InBuffer + 9) = (int)HashCalculator;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAllExFilesByPlatform, __InBuffer, __ReturnBuffer);

				return *(FPlatformExternFiles*)__ReturnBuffer;
			}
		}

		public static bool DiffVersionAssets(FAssetDependenciesInfo InNewVersion, FAssetDependenciesInfo InBaseVersion, ref FAssetDependenciesInfo OutAddAsset, ref FAssetDependenciesInfo OutModifyAsset, ref FAssetDependenciesInfo OutDeleteAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = InNewVersion?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBaseVersion?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutAddAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutModifyAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutDeleteAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __DiffVersionAssets, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAddAsset = *(FAssetDependenciesInfo*)(__OutBuffer);

				OutModifyAsset = *(FAssetDependenciesInfo*)(__OutBuffer + 8);

				OutDeleteAsset = *(FAssetDependenciesInfo*)(__OutBuffer + 16);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void CloseShaderbytecode(FString LibraryName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LibraryName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CloseShaderbytecode, __InBuffer);
			}
		}

		private static uint __ReloadShaderbytecode = 0;

		private static uint __LoadShaderbytecode = 0;

		private static uint __HashStringWithSHA1 = 0;

		private static uint __GetProjectName = 0;

		private static uint __GetProjectIniFiles = 0;

		private static uint __GetProjectFilePath = 0;

		private static uint __GetPakFileInfo = 0;

		private static uint __GetIniConfigs = 0;

		private static uint __GetEngineConfigs = 0;

		private static uint __GetEnabledPluginConfigs = 0;

		private static uint __GetCookedShaderBytecodeFiles = 0;

		private static uint __GetCookedGlobalShaderCacheFiles = 0;

		private static uint __GetCookedAssetRegistryFiles = 0;

		private static uint __GetAvailableMaps = 0;

		private static uint __GetAllExFilesByPlatform = 0;

		private static uint __DiffVersionAssets = 0;

		private static uint __CloseShaderbytecode = 0;
	}
}