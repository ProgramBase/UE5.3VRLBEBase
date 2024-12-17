using Script.CoreUObject;
using Script.Library;
using Script.AssetDefinition;
using Script.UnrealEd;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AssetTools")]
	public partial class UAssetTools : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTools.AssetTools");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AssetTools.AssetTools")]
	public interface IAssetTools : IInterface
	{
		 void RenameReferencingSoftObjectPaths(TArray<UPackage> PackagesToCheck, TMap<FSoftObjectPath, FSoftObjectPath> AssetRedirectorMap);

		 EAssetRenameResult RenameAssetsWithDialog(TArray<FAssetRenameData> AssetsAndNames, bool bAutoCheckout = false);

		 bool RenameAssets(TArray<FAssetRenameData> AssetsAndNames);

		 void OpenEditorForAssets(TArray<UObject> Assets);

		 void MigratePackages(TArray<FName> PackageNamesToMigrate, FString DestinationPath, FMigrationOptions Options = null);

		 void ImportAssetTasks(TArray<UAssetImportTask> ImportTasks);

		 TArray<UObject> ImportAssetsWithDialog(FString DestinationPath);

		 TArray<UObject> ImportAssetsAutomated(UAutomatedAssetImportData ImportData);

		 void FindSoftReferencesToObject(FSoftObjectPath TargetObject, ref TArray<UObject> ReferencingObjects);

		 void ExportAssetsWithDialog(TArray<FString> AssetsToExport, bool bPromptForIndividualFilenames);

		 void ExportAssets(TArray<FString> AssetsToExport, FString ExportPath);

		 UObject DuplicateAssetWithDialogAndTitle(FString AssetName, FString PackagePath, UObject OriginalObject, FText DialogTitle);

		 UObject DuplicateAssetWithDialog(FString AssetName, FString PackagePath, UObject OriginalObject);

		 UObject DuplicateAsset(FString AssetName, FString PackagePath, UObject OriginalObject);

		 void DiffAssets(UObject OldAsset, UObject NewAsset, FRevisionInfo OldRevision, FRevisionInfo NewRevision);

		 void DiffAgainstDepot(UObject InObject, FString InPackagePath, FString InPackageName);

		 void CreateUniqueAssetName(FString InBasePackageName, FString InSuffix, ref FString OutPackageName, ref FString OutAssetName);

		 UObject CreateAssetWithDialog(FString AssetName, FString PackagePath, UClass AssetClass, UFactory Factory, FName CallingContext = null, bool bCallConfigureProperties = true);

		 UObject CreateAsset(FString AssetName, FString PackagePath, UClass AssetClass, UFactory Factory, FName CallingContext = null);

		 void BeginAdvancedCopyPackages(TArray<FName> InputNamesToCopy, FString TargetPath, FAdvancedCopyCompletedEvent OnCopyComplete);
	}
}