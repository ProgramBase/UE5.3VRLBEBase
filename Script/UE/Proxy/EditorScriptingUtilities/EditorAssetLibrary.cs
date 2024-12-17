using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorAssetLibrary")]
	public partial class UEditorAssetLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorAssetLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="AssetPaths">
		/// The list of asset paths to sync to in the Content Browser
		/// </param>
		public static void SyncBrowserToObjects(TArray<FString> AssetPaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPaths?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SyncBrowserToObjects, __InBuffer);
			}
		}

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <param name="Tag">
		/// The tag to set in the metadata.
		/// </param>
		/// <param name="Value">
		/// The string value to associate with the tag.
		/// </param>
		public static void SetMetadataTag(UObject Object, FName Tag, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetMetadataTag, __InBuffer);
			}
		}

		/// <param name="AssetToSaves">
		/// Assets that we want to save.
		/// </param>
		/// <param name="bOnlyIfIsDirty">
		/// Only checkout asset that are dirty.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool SaveLoadedAssets(TArray<UObject> AssetsToSave, bool bOnlyIfIsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetsToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveLoadedAssets, __InBuffer, __ReturnBuffer);

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
		public static bool SaveLoadedAsset(UObject AssetToSave, bool bOnlyIfIsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveLoadedAsset, __InBuffer, __ReturnBuffer);

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
		public static bool SaveDirectory(FString DirectoryPath, bool bOnlyIfIsDirty = true, bool bRecursive = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				*(bool*)(__InBuffer + 9) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetsToSave">
		/// Asset Path of the asset that we want to save.
		/// </param>
		/// <param name="bOnlyIfIsDirty">
		/// Only checkout/save the asset if it's dirty.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool SaveAsset(FString AssetToSave, bool bOnlyIfIsDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyIfIsDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveAsset, __InBuffer, __ReturnBuffer);

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
		public static bool RenameLoadedAsset(UObject SourceAsset, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RenameLoadedAsset, __InBuffer, __ReturnBuffer);

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
		public static bool RenameDirectory(FString SourceDirectoryPath, FString DestinationDirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RenameDirectory, __InBuffer, __ReturnBuffer);

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
		public static bool RenameAsset(FString SourceAssetPath, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RenameAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <param name="Tag">
		/// The tag to remove from the metadata.
		/// </param>
		public static void RemoveMetadataTag(UObject Object, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveMetadataTag, __InBuffer);
			}
		}

		/// <param name="DirectoryPath">
		/// Long Path Name of the directory.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool MakeDirectory(FString DirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the Blueprint asset.
		/// </param>
		/// <returns>
		/// Found or loaded class.
		/// </returns>
		public static UClass LoadBlueprintClass(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadBlueprintClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the asset (that is not a level).
		/// </param>
		/// <returns>
		/// Found or loaded asset.
		/// </returns>
		public static UObject LoadAsset(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
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
		/// The list of asset found.
		/// </returns>
		public static TArray<FString> ListAssets(FString DirectoryPath, bool bRecursive = true, bool bIncludeFolder = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				*(bool*)(__InBuffer + 9) = bIncludeFolder;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ListAssets, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="TagName">
		/// The tag associated with the assets requested.
		/// </param>
		/// <param name="TagValue">
		/// The value associated with the assets requested.
		/// </param>
		/// <returns>
		/// The list of asset found.
		/// </returns>
		public static TArray<FString> ListAssetByTagValue(FName TagName, FString TagValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TagValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ListAssetByTagValue, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path we are trying to find.
		/// </param>
		/// <returns>
		/// The list of all TagName & TagValue.
		/// </returns>
		public static TMap<FName, FString> GetTagValues(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTagValues, __InBuffer, __ReturnBuffer);

				return *(TMap<FName, FString>*)__ReturnBuffer;
			}
		}

		/// <param name="LoadedAsset">
		/// Loaded Asset that exist in the Content Browser.
		/// </param>
		/// <returns>
		/// If valid, the asset Path of the loaded asset.
		/// </returns>
		public static FString GetPathNameForLoadedAsset(UObject LoadedAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LoadedAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPathNameForLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The object from which to retrieve the metadata.
		/// </param>
		/// <returns>
		/// The list of all Tags and Values.
		/// </returns>
		public static TMap<FName, FString> GetMetadataTagValues(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMetadataTagValues, __InBuffer, __ReturnBuffer);

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
		public static FString GetMetadataTag(UObject Object, FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMetadataTag, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the asset that we are looking for (that is not a level).
		/// </param>
		/// <param name="bLoadAssetsToConfirm">
		/// The asset and the referencers will be loaded (if not a level) to confirm the dependencies.
		/// </param>
		/// <returns>
		/// The package path of the referencers.
		/// </returns>
		public static TArray<FString> FindPackageReferencersForAsset(FString AssetPath, bool bLoadAssetsToConfirm = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLoadAssetsToConfirm;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindPackageReferencersForAsset, __InBuffer, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path we are trying to find.
		/// </param>
		/// <returns>
		/// The AssetData found.
		/// </returns>
		public static FAssetData FindAssetData(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindAssetData, __InBuffer, __ReturnBuffer);

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
		public static UObject DuplicateLoadedAsset(UObject SourceAsset, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DuplicateLoadedAsset, __InBuffer, __ReturnBuffer);

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
		/// True if the operation succeeds.
		/// </returns>
		public static bool DuplicateDirectory(FString SourceDirectoryPath, FString DestinationDirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationDirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DuplicateDirectory, __InBuffer, __ReturnBuffer);

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
		public static UObject DuplicateAsset(FString SourceAssetPath, FString DestinationAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __DuplicateAsset, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Long Path Name of the directory.
		/// </param>
		/// <returns>
		/// True if there is any assets.
		/// </returns>
		public static bool DoesDirectoryHaveAssets(FString DirectoryPath, bool bRecursive = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesDirectoryHaveAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Long Path Name of the directory.
		/// </param>
		/// <returns>
		/// True if it does exist and it is valid.
		/// </returns>
		public static bool DoesDirectoryExist(FString DirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesDirectoryExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the asset (that is not a level).
		/// </param>
		/// <returns>
		/// True if it does exist and it is valid.
		/// </returns>
		public static bool DoesAssetExist(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesAssetExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPaths">
		/// Asset Path of the assets (that are not a level).
		/// </param>
		/// <returns>
		/// True if they exist and it is valid.
		/// </returns>
		public static bool DoAssetsExist(TArray<FString> AssetPaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPaths?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoAssetsExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetsToDelete">
		/// Assets that we want to delete.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetsToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteLoadedAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToDelete">
		/// Asset that we want to delete.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool DeleteLoadedAsset(UObject AssetToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Directory that will be mark for delete and deleted.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool DeleteDirectory(FString DirectoryPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPathToDelete">
		/// Asset Path of the asset that we want to delete.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool DeleteAsset(FString AssetPathToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPathToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DeleteAsset, __InBuffer, __ReturnBuffer);

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
		public static bool ConsolidateAssets(UObject AssetToConsolidateTo, TArray<UObject> AssetsToConsolidate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetToConsolidateTo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetsToConsolidate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConsolidateAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToCheckout">
		/// Assets to checkout.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetsToCheckout?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckoutLoadedAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToCheckout">
		/// Asset to checkout.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool CheckoutLoadedAsset(UObject AssetToCheckout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetToCheckout?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckoutLoadedAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DirectoryPath">
		/// Directory of the assets that to checkout.
		/// </param>
		/// <param name="bRecursive">
		/// If the AssetPath is a folder, the search will be recursive and will checkout the asset in the sub folders.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool CheckoutDirectory(FString DirectoryPath, bool bRecursive = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DirectoryPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRecursive;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckoutDirectory, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetToCheckout">
		/// Asset Path of the asset that we want to checkout.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public static bool CheckoutAsset(FString AssetToCheckout)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetToCheckout?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckoutAsset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SyncBrowserToObjects = 0;

		private static uint __SetMetadataTag = 0;

		private static uint __SaveLoadedAssets = 0;

		private static uint __SaveLoadedAsset = 0;

		private static uint __SaveDirectory = 0;

		private static uint __SaveAsset = 0;

		private static uint __RenameLoadedAsset = 0;

		private static uint __RenameDirectory = 0;

		private static uint __RenameAsset = 0;

		private static uint __RemoveMetadataTag = 0;

		private static uint __MakeDirectory = 0;

		private static uint __LoadBlueprintClass = 0;

		private static uint __LoadAsset = 0;

		private static uint __ListAssets = 0;

		private static uint __ListAssetByTagValue = 0;

		private static uint __GetTagValues = 0;

		private static uint __GetPathNameForLoadedAsset = 0;

		private static uint __GetMetadataTagValues = 0;

		private static uint __GetMetadataTag = 0;

		private static uint __FindPackageReferencersForAsset = 0;

		private static uint __FindAssetData = 0;

		private static uint __DuplicateLoadedAsset = 0;

		private static uint __DuplicateDirectory = 0;

		private static uint __DuplicateAsset = 0;

		private static uint __DoesDirectoryHaveAssets = 0;

		private static uint __DoesDirectoryExist = 0;

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
	}
}