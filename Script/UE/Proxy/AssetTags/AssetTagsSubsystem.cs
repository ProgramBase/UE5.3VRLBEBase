using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AssetTags
{
	[PathName("/Script/AssetTags.AssetTagsSubsystem")]
	public partial class UAssetTagsSubsystem : UEngineSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTags.AssetTagsSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Name">
		/// Name of the collection to re-parent.
		/// </param>
		/// <param name="NewParentName">
		/// Name of the new parent collection, or None to have the collection become a root collection.
		/// </param>
		/// <returns>
		/// True if the collection was renamed, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool ReparentCollection(FName Name, FName NewParentName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewParentName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReparentCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to rename.
		/// </param>
		/// <param name="NewName">
		/// Name to give to the collection.
		/// </param>
		/// <returns>
		/// True if the collection was renamed, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool RenameCollection(FName Name, FName NewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAssetsFromCollection(FName Name, TArray<FName> AssetPathNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPathNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAssetsFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPtrs">
		/// Assets to remove.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool RemoveAssetPtrsFromCollection(FName Name, TArray<UObject> AssetPtrs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPtrs?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAssetPtrsFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPtr">
		/// Asset to remove.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool RemoveAssetPtrFromCollection(FName Name, UObject AssetPtr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPtr?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAssetPtrFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAssetFromCollection(FName Name, FName AssetPathName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPathName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAssetFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetDatas">
		/// Assets to remove.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool RemoveAssetDatasFromCollection(FName Name, TArray<FAssetData> AssetDatas)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetDatas?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAssetDatasFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetData">
		/// Asset to remove.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool RemoveAssetDataFromCollection(FName Name, FAssetData AssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAssetDataFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPathNames">
		/// Assets to remove (their path names, eg) /Game/MyFolder/MyAsset.MyAsset).
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool K2_RemoveAssetsFromCollection(FName Name, TArray<FSoftObjectPath> AssetPaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPaths?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_RemoveAssetsFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPath">
		/// Asset to remove (its path, eg) /Game/MyFolder/MyAsset.MyAsset).
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool K2_RemoveAssetFromCollection(FName Name, FSoftObjectPath AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_RemoveAssetFromCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPathName">
		/// Asset to test (its path name, eg) /Game/MyFolder/MyAsset.MyAsset).
		/// </param>
		/// <returns>
		/// Names of the collections that contain the asset.
		/// </returns>
		public virtual TArray<FName> K2_GetCollectionsContainingAsset(FSoftObjectPath AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_GetCollectionsContainingAsset, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPathName">
		/// Asset to add (its path name, eg) /Game/MyFolder/MyAsset.MyAsset).
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool K2_AddAssetToCollection(FName Name, FSoftObjectPath AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AddAssetToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPathNames">
		/// Assets to add (their path names, eg) /Game/MyFolder/MyAsset.MyAsset).
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool K2_AddAssetsToCollection(FName Name, TArray<FSoftObjectPath> AssetPaths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPaths?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_AddAssetsToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPtr">
		/// Asset to test.
		/// </param>
		/// <returns>
		/// Names of the collections that contain the asset.
		/// </returns>
		public virtual TArray<FName> GetCollectionsContainingAssetPtr(UObject AssetPtr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPtr?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCollectionsContainingAssetPtr, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="AssetData">
		/// Asset to test.
		/// </param>
		/// <returns>
		/// Names of the collections that contain the asset.
		/// </returns>
		public virtual TArray<FName> GetCollectionsContainingAssetData(FAssetData AssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCollectionsContainingAssetData, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetCollectionsContainingAsset(FName AssetPathName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPathName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCollectionsContainingAsset, __InBuffer, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Names of all available collections.
		/// </returns>
		public virtual TArray<FName> GetCollections()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCollections, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to test.
		/// </param>
		/// <returns>
		/// Assets in the given collection.
		/// </returns>
		public virtual TArray<FAssetData> GetAssetsInCollection(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetAssetsInCollection, __InBuffer, __ReturnBuffer);

				return *(TArray<FAssetData>*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool EmptyCollection(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __EmptyCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to destroy.
		/// </param>
		/// <returns>
		/// True if the collection was destroyed, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool DestroyCollection(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DestroyCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name to give to the collection.
		/// </param>
		/// <param name="ShareType">
		/// Whether the collection should be local, private, or shared?
		/// </param>
		/// <returns>
		/// True if the collection was created, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool CreateCollection(FName Name, ECollectionScriptingShareType ShareType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ShareType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CreateCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to test.
		/// </param>
		/// <returns>
		/// True if the collection exists, false otherwise.
		/// </returns>
		public virtual bool CollectionExists(FName Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CollectionExists, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddAssetToCollection(FName Name, FName AssetPathName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPathName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAssetToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddAssetsToCollection(FName Name, TArray<FName> AssetPathNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPathNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAssetsToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPtr">
		/// Asset to add.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool AddAssetPtrToCollection(FName Name, UObject AssetPtr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPtr?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAssetPtrToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetPtrs">
		/// Assets to add.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool AddAssetPtrsToCollection(FName Name, TArray<UObject> AssetPtrs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPtrs?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAssetPtrsToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetData">
		/// Asset to add.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool AddAssetDataToCollection(FName Name, FAssetData AssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetData?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAssetDataToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Name">
		/// Name of the collection to modify.
		/// </param>
		/// <param name="AssetDatas">
		/// Assets to add.
		/// </param>
		/// <returns>
		/// True if the collection was modified, false otherwise (see the output log for details on error).
		/// </returns>
		public virtual bool AddAssetDatasToCollection(FName Name, TArray<FAssetData> AssetDatas)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetDatas?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAssetDatasToCollection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ReparentCollection = 0;

		private static uint __RenameCollection = 0;

		private static uint __RemoveAssetsFromCollection = 0;

		private static uint __RemoveAssetPtrsFromCollection = 0;

		private static uint __RemoveAssetPtrFromCollection = 0;

		private static uint __RemoveAssetFromCollection = 0;

		private static uint __RemoveAssetDatasFromCollection = 0;

		private static uint __RemoveAssetDataFromCollection = 0;

		private static uint __K2_RemoveAssetsFromCollection = 0;

		private static uint __K2_RemoveAssetFromCollection = 0;

		private static uint __K2_GetCollectionsContainingAsset = 0;

		private static uint __K2_AddAssetToCollection = 0;

		private static uint __K2_AddAssetsToCollection = 0;

		private static uint __GetCollectionsContainingAssetPtr = 0;

		private static uint __GetCollectionsContainingAssetData = 0;

		private static uint __GetCollectionsContainingAsset = 0;

		private static uint __GetCollections = 0;

		private static uint __GetAssetsInCollection = 0;

		private static uint __EmptyCollection = 0;

		private static uint __DestroyCollection = 0;

		private static uint __CreateCollection = 0;

		private static uint __CollectionExists = 0;

		private static uint __AddAssetToCollection = 0;

		private static uint __AddAssetsToCollection = 0;

		private static uint __AddAssetPtrToCollection = 0;

		private static uint __AddAssetPtrsToCollection = 0;

		private static uint __AddAssetDataToCollection = 0;

		private static uint __AddAssetDatasToCollection = 0;
	}
}