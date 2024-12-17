using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.UnrealEd.EditorAssetSubsystem;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorAssetSubsystem")]
	public partial class UEditorAssetSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorAssetSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <param name="Tag">
		/// The tag to set in the metadata.
		/// </param>
		/// <param name="Value">
		/// The string value to associate with the tag.
		/// </param>
		public virtual void SetMetadataTag(UObject Object, FName Tag, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMetadataTag, __InBuffer);
			}
		}

		/// <param name="AssetsToSave">
		/// Assets that we want to save.
		/// </param>
		/// <param name="bOnlyIfIsDirty">
		/// Only checkout asset that are dirty.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SaveLoadedAssets(TArray<UObject> AssetsToSave, bool bOnlyIfIsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetsToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SaveLoadedAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToSave">
		/// Asset that we want to save.
		/// </param>
		/// <param name="bOnlyIfIsDirty">
		/// Only checkout asset that are dirty.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SaveLoadedAsset(UObject AssetToSave, bool bOnlyIfIsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SaveLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Directory that will be checked out and saved.
		/// </param>
		/// <param name="bOnlyIfIsDirty">
		/// Only checkout asset that are dirty.
		/// </param>
		/// <param name="bRecursive">
		/// The search will be recursive and it will save the asset in the sub folders.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SaveDirectory(FString DirectoryPath, bool bOnlyIfIsDirty = true, bool bRecursive = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				*(bool*)(__InBuffer + 9) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SaveDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToSave">
		/// Asset Path of the asset that we want to save.
		/// </param>
		/// <param name="bOnlyIfIsDirty">
		/// Only checkout/save the asset if it's dirty.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SaveAsset(FString AssetToSave, bool bOnlyIfIsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SaveAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceAsset">
		/// Asset that we want to copy from.
		/// </param>
		/// <param name="DestinationAssetPath">
		/// Asset Path of the duplicated asset.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool RenameLoadedAsset(UObject SourceAsset, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceDirectoryPath">
		/// Directory of the assets that we want to rename from.
		/// </param>
		/// <param name="DestinationDirectoryPath">
		/// Directory of the renamed asset.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool RenameDirectory(FString SourceDirectoryPath, FString DestinationDirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceAssetPath">
		/// Asset Path of the asset that we want to copy from.
		/// </param>
		/// <param name="DestinationAssetPath">
		/// Asset Path of the renamed asset.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool RenameAsset(FString SourceAssetPath, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RemoveOnExtractAssetFromFile(FOnExtractAssetFromFileDynamic Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveOnExtractAssetFromFile, __InBuffer);
			}
		}

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <param name="Tag">
		/// The tag to remove from the metadata.
		/// </param>
		public virtual void RemoveMetadataTag(UObject Object, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveMetadataTag, __InBuffer);
			}
		}

		/// <param name="DirectoryPath">
		/// Long Path Name of the directory.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool MakeDirectory(FString DirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MakeDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the Blueprint asset.
		/// </param>
		/// <returns>
		/// Found or loaded class.
		/// </returns>
		public virtual UClass LoadBlueprintClass(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __LoadBlueprintClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the asset to load
		/// </param>
		/// <returns>
		/// Found or loaded asset.
		/// </returns>
		public virtual UObject LoadAsset(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __LoadAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="TagName">
		/// The tag associated with the assets requested.
		/// </param>
		/// <param name="TagValue">
		/// The value associated with the assets requested.
		/// </param>
		/// <returns>
		/// The list of assets found.
		/// </returns>
		public virtual TArray<FString> ListAssetsByTagValue(FName TagName, FString TagValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TagValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ListAssetsByTagValue, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Directory path of the asset we want the list from.
		/// </param>
		/// <param name="bRecursive">
		/// The search will be recursive and will look in sub folders.
		/// </param>
		/// <param name="bIncludeFolder">
		/// The result will include folders name.
		/// </param>
		/// <returns>
		/// The list of assets found.
		/// </returns>
		public virtual TArray<FString> ListAssets(FString DirectoryPath, bool bRecursive = true, bool bIncludeFolder = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				*(bool*)(__InBuffer + 9) = bIncludeFolder;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ListAssets, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path we are trying to find.
		/// </param>
		/// <returns>
		/// The list of all TagNames & TagValues.
		/// </returns>
		public virtual TMap<FName, FString> GetTagValues(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTagValues, __InBuffer, __ReturnBuffer);

				return *(TMap<FName, FString>*)__ReturnBuffer;
			}
		}

		/// <param name="LoadedAsset">
		/// The loaded asset to get the path of.
		/// </param>
		/// <returns>
		/// If valid, the asset Path of the loaded asset.
		/// </returns>
		public virtual FString GetPathNameForLoadedAsset(UObject LoadedAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LoadedAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPathNameForLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <returns>
		/// The list of all Tags and Values.
		/// </returns>
		public virtual TMap<FName, FString> GetMetadataTagValues(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMetadataTagValues, __InBuffer, __ReturnBuffer);

				return *(TMap<FName, FString>*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <param name="Tag">
		/// The tag to find in the metadata.
		/// </param>
		/// <returns>
		/// The string value associated with the tag.
		/// </returns>
		public virtual FString GetMetadataTag(UObject Object, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMetadataTag, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the asset that we are looking for.
		/// </param>
		/// <param name="bLoadAssetsToConfirm">
		/// Whether the asset and any potential referencers will be loaded to confirm the dependencies.
		/// </param>
		/// <returns>
		/// The package paths of the referencers.
		/// </returns>
		public virtual TArray<FString> FindPackageReferencersForAsset(FString AssetPath, bool bLoadAssetsToConfirm = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLoadAssetsToConfirm;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindPackageReferencersForAsset, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path to retrieve data from.
		/// </param>
		/// <returns>
		/// The AssetData found.
		/// </returns>
		public virtual FAssetData FindAssetData(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindAssetData, __InBuffer, __ReturnBuffer);

				return *(FAssetData*)__ReturnBuffer;
			}
		}

		/// <param name="SourceAsset">
		/// Asset that we want to copy from.
		/// </param>
		/// <param name="DestinationAssetPath">
		/// Asset Path of the duplicated asset.
		/// </param>
		/// <returns>
		/// The duplicated object if the operation succeeds
		/// </returns>
		public virtual UObject DuplicateLoadedAsset(UObject SourceAsset, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="SourceDirectoryPath">
		/// Directory of the assets that we want to duplicate from.
		/// </param>
		/// <param name="DestinationDirectoryPath">
		/// Directory of the duplicated asset.
		/// </param>
		/// <returns>
		/// The duplicated object if the operation succeeds.
		/// </returns>
		public virtual bool DuplicateDirectory(FString SourceDirectoryPath, FString DestinationDirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DuplicateDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SourceAssetPath">
		/// Asset Path of the asset that we want to copy from.
		/// </param>
		/// <param name="DestinationAssetPath">
		/// Asset Path of the duplicated asset.
		/// </param>
		/// <returns>
		/// The duplicated object if the operation succeeds.
		/// </returns>
		public virtual UObject DuplicateAsset(FString SourceAssetPath, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Long Path Name of the directory.
		/// </param>
		/// <returns>
		/// True if it does exist and it is valid.
		/// </returns>
		public virtual bool DoesDirectoryExist(FString DirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesDirectoryExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Long Path Name of the directory.
		/// </param>
		/// <returns>
		/// True if there is any assets.
		/// </returns>
		public virtual bool DoesDirectoryContainAssets(FString DirectoryPath, bool bRecursive = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesDirectoryContainAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path to check for existence.
		/// </param>
		/// <returns>
		/// True if the asset exists and is valid.
		/// </returns>
		public virtual bool DoesAssetExist(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesAssetExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPaths">
		/// Asset Paths of the assets to check for existence.
		/// </param>
		/// <returns>
		/// True if all assets exist and are valid.
		/// </returns>
		public virtual bool DoAssetsExist(TArray<FString> AssetPaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPaths?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoAssetsExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetsToDelete">
		/// Loaded assets to delete.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetsToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteLoadedAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToDelete">
		/// Asset to delete.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool DeleteLoadedAsset(UObject AssetToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Directory that will be marked for deletion and deleted.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool DeleteDirectory(FString DirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPathToDelete">
		/// Asset Path of the asset to delete.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool DeleteAsset(FString AssetPathToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPathToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToConsolidateTo">
		/// Asset to which all references of the AssetsToConsolidate will instead refer to after this operation completes.
		/// </param>
		/// <param name="AssetsToConsolidate">
		/// All references to these assets will be modified to reference AssetToConsolidateTo instead.
		/// </param>
		/// <note>
		/// The AssetsToConsolidate are DELETED by this function.
		/// </note>
		/// <note>
		/// Modified objects will be saved if the operation succeeds.
		/// </note>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool ConsolidateAssets(UObject AssetToConsolidateTo, TArray<UObject> AssetsToConsolidate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetToConsolidateTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetsToConsolidate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ConsolidateAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetsToCheckout">
		/// Assets to checkout.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetsToCheckout?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckoutLoadedAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToCheckout">
		/// Asset to checkout.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool CheckoutLoadedAsset(UObject AssetToCheckout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetToCheckout?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckoutLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Directory of the assets to be checked out.
		/// </param>
		/// <param name="bRecursive">
		/// If the AssetPath is a folder, the search will be recursive and will checkout the assets in the sub folders.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool CheckoutDirectory(FString DirectoryPath, bool bRecursive = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckoutDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToCheckout">
		/// Asset Path of the asset that we want to checkout.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool CheckoutAsset(FString AssetToCheckout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetToCheckout?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckoutAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AddOnExtractAssetFromFile(FOnExtractAssetFromFileDynamic Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddOnExtractAssetFromFile, __InBuffer);
			}
		}

		private static uint __SetMetadataTag = 0;

		private static uint __SaveLoadedAssets = 0;

		private static uint __SaveLoadedAsset = 0;

		private static uint __SaveDirectory = 0;

		private static uint __SaveAsset = 0;

		private static uint __RenameLoadedAsset = 0;

		private static uint __RenameDirectory = 0;

		private static uint __RenameAsset = 0;

		private static uint __RemoveOnExtractAssetFromFile = 0;

		private static uint __RemoveMetadataTag = 0;

		private static uint __MakeDirectory = 0;

		private static uint __LoadBlueprintClass = 0;

		private static uint __LoadAsset = 0;

		private static uint __ListAssetsByTagValue = 0;

		private static uint __ListAssets = 0;

		private static uint __GetTagValues = 0;

		private static uint __GetPathNameForLoadedAsset = 0;

		private static uint __GetMetadataTagValues = 0;

		private static uint __GetMetadataTag = 0;

		private static uint __FindPackageReferencersForAsset = 0;

		private static uint __FindAssetData = 0;

		private static uint __DuplicateLoadedAsset = 0;

		private static uint __DuplicateDirectory = 0;

		private static uint __DuplicateAsset = 0;

		private static uint __DoesDirectoryExist = 0;

		private static uint __DoesDirectoryContainAssets = 0;

		private static uint __DoesAssetExist = 0;

		private static uint __DoAssetsExist = 0;

		private static uint __DeleteLoadedAssets = 0;

		private static uint __DeleteLoadedAsset = 0;

		private static uint __DeleteDirectory = 0;

		private static uint __DeleteAsset = 0;

		private static uint __ConsolidateAssets = 0;

		private static uint __CheckoutLoadedAssets = 0;

		private static uint __CheckoutLoadedAsset = 0;

		private static uint __CheckoutDirectory = 0;

		private static uint __CheckoutAsset = 0;

		private static uint __AddOnExtractAssetFromFile = 0;
	}
}