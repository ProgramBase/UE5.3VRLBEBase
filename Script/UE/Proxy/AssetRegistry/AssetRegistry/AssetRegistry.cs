using Script.CoreUObject;
using Script.Library;

namespace Script.AssetRegistry
{
	[PathName("/Script/AssetRegistry.AssetRegistry")]
	public partial class UAssetRegistry : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetRegistry.AssetRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AssetRegistry.AssetRegistry")]
	public interface IAssetRegistry : IInterface
	{
		 void WaitForPackage(FString PackageName);

		 void WaitForCompletion();

		 void UseFilterToExcludeAssets(ref TArray<FAssetData> AssetDataList, FARFilter Filter);

		 void SearchAllAssets(bool bSynchronousSearch);

		 void ScanPathsSynchronous(TArray<FString> InPaths, bool bForceRescan = false, bool bIgnoreDenyListScanFilters = false);

		 void ScanModifiedAssetFiles(TArray<FString> InFilePaths);

		 void ScanFilesSynchronous(TArray<FString> InFilePaths, bool bForceRescan = false);

		 void RunAssetsThroughFilter(ref TArray<FAssetData> AssetDataList, FARFilter Filter);

		 void PrioritizeSearchPath(FString PathToPrioritize);

		 bool K2_GetReferencers(FName PackageName, FAssetRegistryDependencyOptions ReferenceOptions, ref TArray<FName> OutReferencers);

		 bool K2_GetDependencies(FName PackageName, FAssetRegistryDependencyOptions DependencyOptions, ref TArray<FName> OutDependencies);

		 FAssetData K2_GetAssetByObjectPath(FSoftObjectPath ObjectPath, bool bIncludeOnlyOnDiskAssets = false, bool bSkipARFilteredAssets = true);

		 bool IsSearchAsync();

		 bool IsSearchAllAssets();

		 bool IsLoadingAssets();

		 bool HasAssets(FName PackagePath, bool bRecursive = false);

		 void GetSubPaths(FString InBasePath, ref TArray<FString> OutPathList, bool bInRecurse);

		 void GetDerivedClassNames(TArray<FTopLevelAssetPath> ClassNames, TSet<FTopLevelAssetPath> ExcludedClassNames, ref TSet<FTopLevelAssetPath> OutDerivedClassNames);

		 bool GetAssetsByPaths(TArray<FName> PackagePaths, ref TArray<FAssetData> OutAssetData, bool bRecursive, bool bIncludeOnlyOnDiskAssets);

		 bool GetAssetsByPath(FName PackagePath, ref TArray<FAssetData> OutAssetData, bool bRecursive, bool bIncludeOnlyOnDiskAssets);

		 bool GetAssetsByPackageName(FName PackageName, ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets, bool bSkipARFilteredAssets);

		 bool GetAssetsByClass(FTopLevelAssetPath ClassPathName, ref TArray<FAssetData> OutAssetData, bool bSearchSubClasses);

		 bool GetAssets(FARFilter Filter, ref TArray<FAssetData> OutAssetData, bool bSkipARFilteredAssets);

		 FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets = false);

		 bool GetAncestorClassNames(FTopLevelAssetPath ClassPathName, ref TArray<FTopLevelAssetPath> OutAncestorClassNames);

		 void GetAllCachedPaths(ref TArray<FString> OutPathList);

		 bool GetAllAssets(ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false);
	}
}