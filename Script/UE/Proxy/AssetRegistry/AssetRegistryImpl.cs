using Script.CoreUObject;
using Script.Library;

namespace Script.AssetRegistry
{
	[PathName("/Script/AssetRegistry.AssetRegistryImpl")]
	public partial class UAssetRegistryImpl : UObject, IStaticClass, IAssetRegistry
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetRegistry.AssetRegistryImpl");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void WaitForPackage(FString PackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WaitForPackage, __InBuffer);
			}
		}

		public virtual void WaitForCompletion()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __WaitForCompletion);
			}
		}

		public virtual void UseFilterToExcludeAssets(ref TArray<FAssetData> AssetDataList, FARFilter Filter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetDataList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Filter?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __UseFilterToExcludeAssets, __InBuffer, __OutBuffer);

				AssetDataList = *(TArray<FAssetData>*)(__OutBuffer);

			}
		}

		public virtual void SearchAllAssets(bool bSynchronousSearch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSynchronousSearch;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SearchAllAssets, __InBuffer);
			}
		}

		public virtual void ScanPathsSynchronous(TArray<FString> InPaths, bool bForceRescan = false, bool bIgnoreDenyListScanFilters = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InPaths?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceRescan;

				*(bool*)(__InBuffer + 9) = bIgnoreDenyListScanFilters;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScanPathsSynchronous, __InBuffer);
			}
		}

		public virtual void ScanModifiedAssetFiles(TArray<FString> InFilePaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFilePaths?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScanModifiedAssetFiles, __InBuffer);
			}
		}

		public virtual void ScanFilesSynchronous(TArray<FString> InFilePaths, bool bForceRescan = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFilePaths?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceRescan;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScanFilesSynchronous, __InBuffer);
			}
		}

		public virtual void RunAssetsThroughFilter(ref TArray<FAssetData> AssetDataList, FARFilter Filter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetDataList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Filter?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RunAssetsThroughFilter, __InBuffer, __OutBuffer);

				AssetDataList = *(TArray<FAssetData>*)(__OutBuffer);

			}
		}

		public virtual void PrioritizeSearchPath(FString PathToPrioritize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathToPrioritize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PrioritizeSearchPath, __InBuffer);
			}
		}

		/// <param name="PackageName">
		/// the name of the package for which to gather dependencies (eg, /Game/MyFolder/MyAsset)
		/// </param>
		/// <param name="ReferenceOptions">
		/// which kinds of references to include in the output list
		/// </param>
		/// <param name="OutReferencers">
		/// a list of packages that reference the package whose path is PackageName
		/// </param>
		public virtual bool K2_GetReferencers(FName PackageName, FAssetRegistryDependencyOptions ReferenceOptions, ref TArray<FName> OutReferencers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReferenceOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutReferencers?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_GetReferencers, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutReferencers = *(TArray<FName>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PackageName">
		/// the name of the package for which to gather dependencies (eg, /Game/MyFolder/MyAsset)
		/// </param>
		/// <param name="DependencyOptions">
		/// which kinds of dependencies to include in the output list
		/// </param>
		/// <param name="OutDependencies">
		/// a list of packages that are referenced by the package whose path is PackageName
		/// </param>
		public virtual bool K2_GetDependencies(FName PackageName, FAssetRegistryDependencyOptions DependencyOptions, ref TArray<FName> OutDependencies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DependencyOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutDependencies?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_GetDependencies, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutDependencies = *(TArray<FName>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ObjectPath">
		/// the path of the object to be looked up
		/// </param>
		/// <param name="bIncludeOnlyOnDiskAssets">
		/// if true, in-memory objects will be ignored. The call will be faster.
		/// </param>
		/// <param name="bSkipARFilteredAssets">
		/// If true, skips Objects that return true for IsAsset but are not assets in the current platform.
		/// </param>
		/// <returns>
		/// the assets data;Will be invalid if object could not be found
		/// </returns>
		public virtual FAssetData K2_GetAssetByObjectPath(FSoftObjectPath ObjectPath, bool bIncludeOnlyOnDiskAssets = false, bool bSkipARFilteredAssets = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = ObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeOnlyOnDiskAssets;

				*(bool*)(__InBuffer + 9) = bSkipARFilteredAssets;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetAssetByObjectPath, __InBuffer, __ReturnBuffer);

				return *(FAssetData*)__ReturnBuffer;
			}
		}

		public virtual bool IsSearchAsync()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSearchAsync, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSearchAllAssets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSearchAllAssets, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLoadingAssets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLoadingAssets, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PackagePath">
		/// the path to query asset data in (eg, /Game/MyFolder)
		/// </param>
		/// <param name="bRecursive">
		/// if true, the supplied path will be tested recursively
		/// </param>
		public virtual bool HasAssets(FName PackagePath, bool bRecursive = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetSubPaths(FString InBasePath, ref TArray<FString> OutPathList, bool bInRecurse)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InBasePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPathList?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInRecurse;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSubPaths, __InBuffer, __OutBuffer);

				OutPathList = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetDerivedClassNames(TArray<FTopLevelAssetPath> ClassNames, TSet<FTopLevelAssetPath> ExcludedClassNames, ref TSet<FTopLevelAssetPath> OutDerivedClassNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ClassNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExcludedClassNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutDerivedClassNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetDerivedClassNames, __InBuffer, __OutBuffer);

				OutDerivedClassNames = *(TSet<FTopLevelAssetPath>*)(__OutBuffer);

			}
		}

		/// <param name="PackagePaths">
		/// the paths to query asset data in (eg, /Game/MyFolder)
		/// </param>
		/// <param name="OutAssetData">
		/// the list of assets in this path
		/// </param>
		/// <param name="bRecursive">
		/// if true, all supplied paths will be searched recursively
		/// </param>
		public virtual bool GetAssetsByPaths(TArray<FName> PackagePaths, ref TArray<FAssetData> OutAssetData, bool bRecursive, bool bIncludeOnlyOnDiskAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = PackagePaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bRecursive;

				*(bool*)(__InBuffer + 17) = bIncludeOnlyOnDiskAssets;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAssetsByPaths, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PackagePath">
		/// the path to query asset data in (eg, /Game/MyFolder)
		/// </param>
		/// <param name="OutAssetData">
		/// the list of assets in this path
		/// </param>
		/// <param name="bRecursive">
		/// if true, all supplied paths will be searched recursively
		/// </param>
		public virtual bool GetAssetsByPath(FName PackagePath, ref TArray<FAssetData> OutAssetData, bool bRecursive, bool bIncludeOnlyOnDiskAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bRecursive;

				*(bool*)(__InBuffer + 17) = bIncludeOnlyOnDiskAssets;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAssetsByPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PackageName">
		/// the package name for the requested assets (eg, /Game/MyFolder/MyAsset)
		/// </param>
		/// <param name="OutAssetData">
		/// the list of assets in this path
		/// </param>
		/// <param name="bSkipARFilteredAssets">
		/// If true, skips Objects that return true for IsAsset but are not assets in the current platform.
		/// </param>
		public virtual bool GetAssetsByPackageName(FName PackageName, ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets, bool bSkipARFilteredAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIncludeOnlyOnDiskAssets;

				*(bool*)(__InBuffer + 17) = bSkipARFilteredAssets;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAssetsByPackageName, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ClassPathName">
		/// the full path of the class name of the assets requested, in a TopLevelAssetPath structure.
		/// </param>
		/// <param name="OutAssetData">
		/// the list of assets in this path
		/// </param>
		/// <param name="bSearchSubClasses">
		/// if true, all subclasses of the passed in class will be searched as well
		/// </param>
		public virtual bool GetAssetsByClass(FTopLevelAssetPath ClassPathName, ref TArray<FAssetData> OutAssetData, bool bSearchSubClasses)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ClassPathName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSearchSubClasses;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAssetsByClass, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Filter">
		/// filter to apply to the assets in the AssetRegistry
		/// </param>
		/// <param name="OutAssetData">
		/// the list of assets in this path
		/// </param>
		/// <param name="bSkipARFilteredAssets">
		/// If true, skips Objects that return true for IsAsset but are not assets in the current platform.
		/// </param>
		public virtual bool GetAssets(FARFilter Filter, ref TArray<FAssetData> OutAssetData, bool bSkipARFilteredAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Filter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSkipARFilteredAssets;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAssets, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeOnlyOnDiskAssets;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAssetByObjectPath, __InBuffer, __ReturnBuffer);

				return *(FAssetData*)__ReturnBuffer;
			}
		}

		public virtual bool GetAncestorClassNames(FTopLevelAssetPath ClassPathName, ref TArray<FTopLevelAssetPath> OutAncestorClassNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ClassPathName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAncestorClassNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAncestorClassNames, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAncestorClassNames = *(TArray<FTopLevelAssetPath>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetAllCachedPaths(ref TArray<FString> OutPathList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutPathList?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllCachedPaths, __InBuffer, __OutBuffer);

				OutPathList = *(TArray<FString>*)(__OutBuffer);

			}
		}

		/// <param name="OutAssetData">
		/// the list of assets in this path
		/// </param>
		public virtual bool GetAllAssets(ref TArray<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = OutAssetData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludeOnlyOnDiskAssets;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAllAssets, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAssetData = *(TArray<FAssetData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __WaitForPackage = 0;

		private static uint __WaitForCompletion = 0;

		private static uint __UseFilterToExcludeAssets = 0;

		private static uint __SearchAllAssets = 0;

		private static uint __ScanPathsSynchronous = 0;

		private static uint __ScanModifiedAssetFiles = 0;

		private static uint __ScanFilesSynchronous = 0;

		private static uint __RunAssetsThroughFilter = 0;

		private static uint __PrioritizeSearchPath = 0;

		private static uint __K2_GetReferencers = 0;

		private static uint __K2_GetDependencies = 0;

		private static uint __K2_GetAssetByObjectPath = 0;

		private static uint __IsSearchAsync = 0;

		private static uint __IsSearchAllAssets = 0;

		private static uint __IsLoadingAssets = 0;

		private static uint __HasAssets = 0;

		private static uint __GetSubPaths = 0;

		private static uint __GetDerivedClassNames = 0;

		private static uint __GetAssetsByPaths = 0;

		private static uint __GetAssetsByPath = 0;

		private static uint __GetAssetsByPackageName = 0;

		private static uint __GetAssetsByClass = 0;

		private static uint __GetAssets = 0;

		private static uint __GetAssetByObjectPath = 0;

		private static uint __GetAncestorClassNames = 0;

		private static uint __GetAllCachedPaths = 0;

		private static uint __GetAllAssets = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}