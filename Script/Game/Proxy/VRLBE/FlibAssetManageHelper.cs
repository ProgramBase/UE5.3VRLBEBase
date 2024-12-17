using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.FlibAssetManageHelper")]
	public partial class UFlibAssetManageHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.FlibAssetManageHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool SaveStringToFile(FString InFile, FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveStringToFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString PackagePathToFilename(FString InPackagePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PackagePathToFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool ModuleIsEnabled(FString InModuleName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InModuleName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ModuleIsEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString LongPackageNameToPackagePath(FString InLongPackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLongPackageName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LongPackageNameToPackagePath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString LongPackageNameToFilename(FString InLongPackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLongPackageName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LongPackageNameToFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool LoadFileToString(FString InFile, ref FString OutString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LoadFileToString, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutString = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetSpecifyAssetDetail(FString InLongPackageName, ref FAssetDetail OutAssetDetail)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InLongPackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetDetail?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetSpecifyAssetDetail, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetDetail = *(FAssetDetail*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetRedirectorList(TArray<FString> InFilterPackagePaths, ref TArray<FAssetDetail> OutRedirector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFilterPackagePaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutRedirector?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetRedirectorList, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutRedirector = *(TArray<FAssetDetail>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetPluginModuleAbsDir(FString InPluginModuleName, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InPluginModuleName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetPluginModuleAbsDir, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetModuleNameByRelativePath(FString InRelativePath, ref FString OutModuleName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InRelativePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutModuleName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetModuleNameByRelativePath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutModuleName = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetEnableModuleAbsDir(FString InModuleName, ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InModuleName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetEnableModuleAbsDir, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetAssetReferenceEx(FAssetDetail InAsset, TArray<EAssetRegistryDependencyTypeEx> SearchAssetDepTypes, ref TArray<FAssetDetail> OutRefAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SearchAssetDepTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutRefAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAssetReferenceEx, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutRefAsset = *(TArray<FAssetDetail>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetAllEnabledModuleName(ref TMap<FString, FString> OutModules)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutModules?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllEnabledModuleName, __InBuffer, __OutBuffer);

				OutModules = *(TMap<FString, FString>*)(__OutBuffer);

			}
		}

		public static bool FindFilesRecursive(FString InStartDir, ref TArray<FString> OutFileList, bool InRecursive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InStartDir?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutFileList?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = InRecursive;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FindFilesRecursive, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFileList = *(TArray<FString>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void FilterNoRefAssetsWithIgnoreFilter(TArray<FAssetDetail> InAssetsDetail, TArray<FString> InIgnoreFilters, ref TArray<FAssetDetail> OutHasRefAssetsDetail, ref TArray<FAssetDetail> OutDontHasRefAssetsDetail)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InAssetsDetail?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InIgnoreFilters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutHasRefAssetsDetail?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutDontHasRefAssetsDetail?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __FilterNoRefAssetsWithIgnoreFilter, __InBuffer, __OutBuffer);

				OutHasRefAssetsDetail = *(TArray<FAssetDetail>*)(__OutBuffer);

				OutDontHasRefAssetsDetail = *(TArray<FAssetDetail>*)(__OutBuffer + 8);

			}
		}

		public static void FilterNoRefAssets(TArray<FAssetDetail> InAssetsDetail, ref TArray<FAssetDetail> OutHasRefAssetsDetail, ref TArray<FAssetDetail> OutDontHasRefAssetsDetail)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InAssetsDetail?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutHasRefAssetsDetail?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutDontHasRefAssetsDetail?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __FilterNoRefAssets, __InBuffer, __OutBuffer);

				OutHasRefAssetsDetail = *(TArray<FAssetDetail>*)(__OutBuffer);

				OutDontHasRefAssetsDetail = *(TArray<FAssetDetail>*)(__OutBuffer + 8);

			}
		}

		public static bool FilenameToPackagePath(FString InAbsPath, ref FString OutPackagePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAbsPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __FilenameToPackagePath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPackagePath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ExportCookPakCommandToFile(TArray<FString> InCommand, FString InFile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InCommand?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFile?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ExportCookPakCommandToFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ConvRelativeDirToAbsDir(FString InRelativePath, ref FString OutAbsPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InRelativePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAbsPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ConvRelativeDirToAbsDir, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAbsPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CombineAssetsDetailAsFAssetDepenInfo(TArray<FAssetDetail> InAssetsDetailList, ref FAssetDependenciesInfo OutAssetInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAssetsDetailList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CombineAssetsDetailAsFAssetDepenInfo, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetInfo = *(FAssetDependenciesInfo*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FAssetDependenciesInfo CombineAssetDependencies(FAssetDependenciesInfo A, FAssetDependenciesInfo B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CombineAssetDependencies, __InBuffer, __ReturnBuffer);

				return *(FAssetDependenciesInfo*)__ReturnBuffer;
			}
		}

		private static uint __SaveStringToFile = 0;

		private static uint __PackagePathToFilename = 0;

		private static uint __ModuleIsEnabled = 0;

		private static uint __LongPackageNameToPackagePath = 0;

		private static uint __LongPackageNameToFilename = 0;

		private static uint __LoadFileToString = 0;

		private static uint __GetSpecifyAssetDetail = 0;

		private static uint __GetRedirectorList = 0;

		private static uint __GetPluginModuleAbsDir = 0;

		private static uint __GetModuleNameByRelativePath = 0;

		private static uint __GetEnableModuleAbsDir = 0;

		private static uint __GetAssetReferenceEx = 0;

		private static uint __GetAllEnabledModuleName = 0;

		private static uint __FindFilesRecursive = 0;

		private static uint __FilterNoRefAssetsWithIgnoreFilter = 0;

		private static uint __FilterNoRefAssets = 0;

		private static uint __FilenameToPackagePath = 0;

		private static uint __ExportCookPakCommandToFile = 0;

		private static uint __ConvRelativeDirToAbsDir = 0;

		private static uint __CombineAssetsDetailAsFAssetDepenInfo = 0;

		private static uint __CombineAssetDependencies = 0;
	}
}