using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorLoadingAndSavingUtils")]
	public partial class UEditorLoadingAndSavingUtils : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorLoadingAndSavingUtils");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="PackagesToUnload">
		/// Array of packages to unload.
		/// </param>
		public static void UnloadPackages(TArray<UPackage> PackagesToUnload, ref bool bOutAnyPackagesUnloaded, ref FText OutErrorMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PackagesToUnload?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutAnyPackagesUnloaded;

				*(nint*)(__InBuffer + 9) = OutErrorMessage?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __UnloadPackages, __InBuffer, __OutBuffer);

				bOutAnyPackagesUnloaded = *(bool*)(__OutBuffer);

				OutErrorMessage = *(FText*)(__OutBuffer + 1);

			}
		}

		/// <param name="PackagesToSave">
		/// The list of packages to save.  Both map and content packages are supported
		/// </param>
		/// <param name="bCheckDirty">
		/// If true, only packages that are dirty in PackagesToSave will be saved
		/// </param>
		/// <returns>
		/// true on success, false on fail.
		/// </returns>
		public static bool SavePackagesWithDialog(TArray<UPackage> PackagesToSave, bool bOnlyDirty)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PackagesToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SavePackagesWithDialog, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PackagesToSave">
		/// The list of packages to save.  Both map and content packages are supported
		/// </param>
		/// <param name="bCheckDirty">
		/// If true, only packages that are dirty in PackagesToSave will be saved
		/// </param>
		/// <returns>
		/// true on success, false on fail.
		/// </returns>
		public static bool SavePackages(TArray<UPackage> PackagesToSave, bool bOnlyDirty)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PackagesToSave?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SavePackages, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// The world to save.
		/// </param>
		/// <param name="AssetPath">
		/// The valid content directory path and name for the asset.  E.g "/Game/MyMap"
		/// </param>
		/// <returns>
		/// true if the map was saved successfully.
		/// </returns>
		public static bool SaveMap(UWorld World, FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveMap, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bSaveMapPackages">
		/// true if map packages should be saved
		/// </param>
		/// <param name="bSaveContentPackages">
		/// true if we should save content packages.
		/// </param>
		/// <returns>
		/// true on success, false on fail.
		/// </returns>
		public static bool SaveDirtyPackagesWithDialog(bool bSaveMapPackages, bool bSaveContentPackages)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bSaveMapPackages;

				*(bool*)(__InBuffer + 1) = bSaveContentPackages;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveDirtyPackagesWithDialog, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bSaveMapPackages">
		/// true if map packages should be saved
		/// </param>
		/// <param name="bSaveContentPackages">
		/// true if we should save content packages.
		/// </param>
		/// <returns>
		/// true on success, false on fail.
		/// </returns>
		public static bool SaveDirtyPackages(bool bSaveMapPackages, bool bSaveContentPackages)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bSaveMapPackages;

				*(bool*)(__InBuffer + 1) = bSaveContentPackages;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SaveDirtyPackages, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true on success, False on fail
		/// </returns>
		public static bool SaveCurrentLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __SaveCurrentLevel, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PackagesToReload">
		/// The list of packages that should be reloaded
		/// </param>
		/// <param name="bOutAnyPackagesReloaded">
		/// True if the set of loaded packages was changed
		/// </param>
		/// <param name="OutErrorMessage">
		/// An error message specifying any problems with reloading packages
		/// </param>
		/// <param name="InteractionMode">
		/// Whether the function is allowed to ask the user questions (such as whether to reload dirty packages)
		/// </param>
		public static void ReloadPackages(TArray<UPackage> PackagesToReload, ref bool bOutAnyPackagesReloaded, ref FText OutErrorMessage, EReloadPackagesInteractionMode InteractionMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = PackagesToReload?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutAnyPackagesReloaded;

				*(nint*)(__InBuffer + 9) = OutErrorMessage?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 17) = (byte)InteractionMode;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ReloadPackages, __InBuffer, __OutBuffer);

				bOutAnyPackagesReloaded = *(bool*)(__OutBuffer);

				OutErrorMessage = *(FText*)(__OutBuffer + 1);

			}
		}

		public static UWorld NewMapFromTemplate(FString PathToTemplateLevel, bool bSaveExistingMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PathToTemplateLevel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSaveExistingMap;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NewMapFromTemplate, __InBuffer, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public static UWorld NewBlankMap(bool bSaveExistingMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSaveExistingMap;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NewBlankMap, __InBuffer, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public static UWorld LoadMapWithDialog()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __LoadMapWithDialog, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		/// <param name="Filename">
		/// Level package filename, including path.
		/// </param>
		/// <returns>
		/// true if the map was loaded successfully.
		/// </returns>
		public static UWorld LoadMap(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadMap, __InBuffer, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public static void ImportScene(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ImportScene, __InBuffer);
			}
		}

		/// <param name="OutDirtyPackages">
		/// Array to append dirty packages to.
		/// </param>
		public static void GetDirtyMapPackages(ref TArray<UPackage> OutDirtyPackages)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutDirtyPackages?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetDirtyMapPackages, __InBuffer, __OutBuffer);

				OutDirtyPackages = *(TArray<UPackage>*)(__OutBuffer);

			}
		}

		/// <param name="OutDirtyPackages">
		/// Array to append dirty packages to.
		/// </param>
		public static void GetDirtyContentPackages(ref TArray<UPackage> OutDirtyPackages)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutDirtyPackages?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetDirtyContentPackages, __InBuffer, __OutBuffer);

				OutDirtyPackages = *(TArray<UPackage>*)(__OutBuffer);

			}
		}

		public static void ExportScene(bool bExportSelectedActorsOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bExportSelectedActorsOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ExportScene, __InBuffer);
			}
		}

		private static uint __UnloadPackages = 0;

		private static uint __SavePackagesWithDialog = 0;

		private static uint __SavePackages = 0;

		private static uint __SaveMap = 0;

		private static uint __SaveDirtyPackagesWithDialog = 0;

		private static uint __SaveDirtyPackages = 0;

		private static uint __SaveCurrentLevel = 0;

		private static uint __ReloadPackages = 0;

		private static uint __NewMapFromTemplate = 0;

		private static uint __NewBlankMap = 0;

		private static uint __LoadMapWithDialog = 0;

		private static uint __LoadMap = 0;

		private static uint __ImportScene = 0;

		private static uint __GetDirtyMapPackages = 0;

		private static uint __GetDirtyContentPackages = 0;

		private static uint __ExportScene = 0;
	}
}