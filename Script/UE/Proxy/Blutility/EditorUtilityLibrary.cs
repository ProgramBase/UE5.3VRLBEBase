using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.UMGEditor;
using Script.ContentBrowserData;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityLibrary")]
	public partial class UEditorUtilityLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="FolderList">
		/// The list of folders to sync to in the Content Browser
		/// </param>
		public static void SyncBrowserToFolders(TArray<FString> FolderList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FolderList?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SyncBrowserToFolders, __InBuffer);
			}
		}

		public static void RenameAsset(UObject Asset, FString NewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RenameAsset, __InBuffer);
			}
		}

		public static TArray<AActor> GetSelectionSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectionSet, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public static void GetSelectionBounds(ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SphereRadius;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSelectionBounds, __InBuffer, __OutBuffer);

				Origin = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

				SphereRadius = *(float*)(__OutBuffer + 16);

			}
		}

		public static TArray<FString> GetSelectedPathViewFolderPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedPathViewFolderPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetSelectedFolderPaths()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedFolderPaths, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<UClass> GetSelectedBlueprintClasses()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedBlueprintClasses, __ReturnBuffer);

				return *(TArray<UClass>*)__ReturnBuffer;
			}
		}

		public static TArray<UObject> GetSelectedAssetsOfClass(UClass AssetClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedAssetsOfClass, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public static TArray<UObject> GetSelectedAssets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedAssets, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public static TArray<FAssetData> GetSelectedAssetData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedAssetData, __ReturnBuffer);

				return *(TArray<FAssetData>*)__ReturnBuffer;
			}
		}

		/// <param name="OutPath">
		/// The returned path if successfully found
		/// </param>
		/// <returns>
		/// Whether a path was successfully returned
		/// </returns>
		public static bool GetCurrentContentBrowserPath(ref FString OutPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentContentBrowserPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutPath = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FContentBrowserItemPath GetCurrentContentBrowserItemPath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentContentBrowserItemPath, __ReturnBuffer);

				return *(FContentBrowserItemPath*)__ReturnBuffer;
			}
		}

		/// <param name="PathToActor">
		/// The path to the actor (e.g. PersistentLevel.PlayerStart)
		/// </param>
		/// <returns>
		/// A reference to the actor, or none if it wasn't found
		/// </returns>
		public virtual AActor GetActorReference(FString PathToActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathToActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorReference, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static void ConvertToEditorUtilityWidget(UWidgetBlueprint WidgetBP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WidgetBP?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ConvertToEditorUtilityWidget, __InBuffer);
			}
		}

		private static uint __SyncBrowserToFolders = 0;

		private static uint __RenameAsset = 0;

		private static uint __GetSelectionSet = 0;

		private static uint __GetSelectionBounds = 0;

		private static uint __GetSelectedPathViewFolderPaths = 0;

		private static uint __GetSelectedFolderPaths = 0;

		private static uint __GetSelectedBlueprintClasses = 0;

		private static uint __GetSelectedAssetsOfClass = 0;

		private static uint __GetSelectedAssets = 0;

		private static uint __GetSelectedAssetData = 0;

		private static uint __GetCurrentContentBrowserPath = 0;

		private static uint __GetCurrentContentBrowserItemPath = 0;

		private static uint __GetActorReference = 0;

		private static uint __ConvertToEditorUtilityWidget = 0;
	}
}