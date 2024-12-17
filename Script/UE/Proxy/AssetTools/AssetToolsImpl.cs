using Script.CoreUObject;
using Script.Library;
using Script.AssetDefinition;
using Script.UnrealEd;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AssetToolsImpl")]
	public partial class UAssetToolsImpl : UObject, IStaticClass, IAssetTools
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTools.AssetToolsImpl");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="PackagesToCheck">
		/// Packages to check for referencing FSoftObjectPath.
		/// </param>
		/// <param name="AssetRedirectorMap">
		/// Map from old asset path to new asset path
		/// </param>
		public virtual void RenameReferencingSoftObjectPaths(TArray<UPackage> PackagesToCheck, TMap<FSoftObjectPath, FSoftObjectPath> AssetRedirectorMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PackagesToCheck?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetRedirectorMap?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RenameReferencingSoftObjectPaths, __InBuffer);
			}
		}

		public virtual EAssetRenameResult RenameAssetsWithDialog(TArray<FAssetRenameData> AssetsAndNames, bool bAutoCheckout = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetsAndNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAutoCheckout;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameAssetsWithDialog, __InBuffer, __ReturnBuffer);

				return *(EAssetRenameResult*)__ReturnBuffer;
			}
		}

		public virtual bool RenameAssets(TArray<FAssetRenameData> AssetsAndNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetsAndNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OpenEditorForAssets(TArray<UObject> Assets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Assets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OpenEditorForAssets, __InBuffer);
			}
		}

		public virtual void MigratePackages(TArray<FName> PackageNamesToMigrate, FString DestinationPath, FMigrationOptions Options = null)
		{
			unsafe
			{
				Options ??= new FMigrationOptions();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = PackageNamesToMigrate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MigratePackages, __InBuffer);
			}
		}

		/// <param name="ImportTasks">
		/// Tasks that specify how to import each file
		/// </param>
		public virtual void ImportAssetTasks(TArray<UAssetImportTask> ImportTasks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ImportTasks?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ImportAssetTasks, __InBuffer);
			}
		}

		/// <param name="DestinationPath">
		/// Path to import files to
		/// </param>
		/// <returns>
		/// list of successfully imported assets
		/// </returns>
		public virtual TArray<UObject> ImportAssetsWithDialog(FString DestinationPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DestinationPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportAssetsWithDialog, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		/// <param name="AutomatedImportData">
		/// Data that specifies how to import each file
		/// </param>
		/// <returns>
		/// list of successfully imported assets
		/// </returns>
		public virtual TArray<UObject> ImportAssetsAutomated(UAutomatedAssetImportData ImportData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ImportData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ImportAssetsAutomated, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public virtual void FindSoftReferencesToObject(FSoftObjectPath TargetObject, ref TArray<UObject> ReferencingObjects)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReferencingObjects?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __FindSoftReferencesToObject, __InBuffer, __OutBuffer);

				ReferencingObjects = *(TArray<UObject>*)(__OutBuffer);

			}
		}

		/// <param name="AssetsToExport">
		/// List of assets to export
		/// </param>
		/// <param name="ExportPath">
		/// The directory path to export to.
		/// </param>
		public virtual void ExportAssetsWithDialog(TArray<FString> AssetsToExport, bool bPromptForIndividualFilenames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetsToExport?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bPromptForIndividualFilenames;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ExportAssetsWithDialog, __InBuffer);
			}
		}

		/// <param name="AssetsToExport">
		/// List of full asset names (e.g /Game/Path/Asset) to export
		/// </param>
		/// <param name="ExportPath">
		/// The directory path to export to.
		/// </param>
		public virtual void ExportAssets(TArray<FString> AssetsToExport, FString ExportPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetsToExport?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExportPath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ExportAssets, __InBuffer);
			}
		}

		public virtual UObject DuplicateAssetWithDialogAndTitle(FString AssetName, FString PackagePath, UObject OriginalObject, FText DialogTitle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OriginalObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = DialogTitle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateAssetWithDialogAndTitle, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual UObject DuplicateAssetWithDialog(FString AssetName, FString PackagePath, UObject OriginalObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OriginalObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateAssetWithDialog, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual UObject DuplicateAsset(FString AssetName, FString PackagePath, UObject OriginalObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OriginalObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual void DiffAssets(UObject OldAsset, UObject NewAsset, FRevisionInfo OldRevision, FRevisionInfo NewRevision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = OldAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OldRevision?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = NewRevision?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DiffAssets, __InBuffer);
			}
		}

		/// <param name="InObject">
		/// - The object we want to compare against the depot
		/// </param>
		/// <param name="InPackagePath">
		/// - The fullpath to the package
		/// </param>
		/// <param name="InPackageName">
		/// - The name of the package
		/// </param>
		public virtual void DiffAgainstDepot(UObject InObject, FString InPackagePath, FString InPackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InPackageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DiffAgainstDepot, __InBuffer);
			}
		}

		public virtual void CreateUniqueAssetName(FString InBasePackageName, FString InSuffix, ref FString OutPackageName, ref FString OutAssetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InBasePackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSuffix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutPackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutAssetName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CreateUniqueAssetName, __InBuffer, __OutBuffer);

				OutPackageName = *(FString*)(__OutBuffer);

				OutAssetName = *(FString*)(__OutBuffer + 8);

			}
		}

		public virtual UObject CreateAssetWithDialog(FString AssetName, FString PackagePath, UClass AssetClass, UFactory Factory, FName CallingContext = null, bool bCallConfigureProperties = true)
		{
			unsafe
			{
				CallingContext ??= new FName("None");

				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AssetClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Factory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = CallingContext?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bCallConfigureProperties;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateAssetWithDialog, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="AssetName">
		/// the name of the new asset
		/// </param>
		/// <param name="PackagePath">
		/// the package that will contain the new asset
		/// </param>
		/// <param name="AssetClass">
		/// the class of the new asset
		/// </param>
		/// <param name="Factory">
		/// the factory that will build the new asset
		/// </param>
		/// <param name="CallingContext">
		/// optional name of the module or method calling CreateAsset() - this is passed to the factory
		/// </param>
		/// <returns>
		/// the new asset or NULL if it fails
		/// </returns>
		public virtual UObject CreateAsset(FString AssetName, FString PackagePath, UClass AssetClass, UFactory Factory, FName CallingContext = null)
		{
			unsafe
			{
				CallingContext ??= new FName("None");

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AssetClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Factory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = CallingContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual void BeginAdvancedCopyPackages(TArray<FName> InputNamesToCopy, FString TargetPath, FAdvancedCopyCompletedEvent OnCopyComplete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InputNamesToCopy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnCopyComplete?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BeginAdvancedCopyPackages, __InBuffer);
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

		private static uint __RenameReferencingSoftObjectPaths = 0;

		private static uint __RenameAssetsWithDialog = 0;

		private static uint __RenameAssets = 0;

		private static uint __OpenEditorForAssets = 0;

		private static uint __MigratePackages = 0;

		private static uint __ImportAssetTasks = 0;

		private static uint __ImportAssetsWithDialog = 0;

		private static uint __ImportAssetsAutomated = 0;

		private static uint __FindSoftReferencesToObject = 0;

		private static uint __ExportAssetsWithDialog = 0;

		private static uint __ExportAssets = 0;

		private static uint __DuplicateAssetWithDialogAndTitle = 0;

		private static uint __DuplicateAssetWithDialog = 0;

		private static uint __DuplicateAsset = 0;

		private static uint __DiffAssets = 0;

		private static uint __DiffAgainstDepot = 0;

		private static uint __CreateUniqueAssetName = 0;

		private static uint __CreateAssetWithDialog = 0;

		private static uint __CreateAsset = 0;

		private static uint __BeginAdvancedCopyPackages = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}