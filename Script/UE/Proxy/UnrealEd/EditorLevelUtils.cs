using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorLevelUtils")]
	public partial class UEditorLevelUtils : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorLevelUtils");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Level">
		/// The level to modify.
		/// </param>
		/// <param name="bShouldBeVisible">
		/// The level's new visibility state.
		/// </param>
		/// <param name="bForceLayersVisible">
		/// If true and the level is visible, force the level's layers to be visible.
		/// </param>
		/// <param name="ModifyMode">
		/// ELevelVisibilityDirtyMode mode value.
		/// </param>
		public static void SetLevelVisibility(ULevel Level, bool bShouldBeVisible, bool bForceLayersVisible, ELevelVisibilityDirtyMode ModifyMode = ELevelVisibilityDirtyMode.ModifyOnChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = Level?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldBeVisible;

				*(bool*)(__InBuffer + 9) = bForceLayersVisible;

				*(byte*)(__InBuffer + 10) = (byte)ModifyMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLevelVisibility, __InBuffer);
			}
		}

		/// <param name="Levels">
		/// The levels to modify.
		/// </param>
		/// <param name="bShouldBeVisible">
		/// The level's new visibility state for each level.
		/// </param>
		/// <param name="bForceLayersVisible">
		/// If true and the level is visible, force the level's layers to be visible.
		/// </param>
		/// <param name="ModifyMode">
		/// ELevelVisibilityDirtyMode mode value.
		/// </param>
		public static void SetLevelsVisibility(TArray<ULevel> Levels, TArray<bool> bShouldBeVisible, bool bForceLayersVisible, ELevelVisibilityDirtyMode ModifyMode = ELevelVisibilityDirtyMode.ModifyOnChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Levels?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = bShouldBeVisible?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bForceLayersVisible;

				*(byte*)(__InBuffer + 17) = (byte)ModifyMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLevelsVisibility, __InBuffer);
			}
		}

		/// <param name="DestStreamingLevel">
		/// The destination streaming level of the current world to move the actors to
		/// </param>
		/// <param name="bWarnAboutReferences">
		/// Whether or not to show a modal warning about referenced actors that may no longer function after being moved
		/// </param>
		/// <returns>
		/// The number of actors that were successfully moved to the new level
		/// </returns>
		public static int MoveSelectedActorsToLevel(ULevelStreaming DestLevel, bool bWarnAboutReferences = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DestLevel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bWarnAboutReferences;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MoveSelectedActorsToLevel, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ActorsToMove">
		/// List of actors to move
		/// </param>
		/// <param name="DestStreamingLevel">
		/// The destination streaming level of the current world to move the actors to
		/// </param>
		/// <param name="bWarnAboutReferences">
		/// Whether or not to show a modal warning about referenced actors that may no longer function after being moved
		/// </param>
		/// <returns>
		/// The number of actors that were successfully moved to the new level
		/// </returns>
		public static int MoveActorsToLevel(TArray<AActor> ActorsToMove, ULevelStreaming DestStreamingLevel, bool bWarnAboutReferences = true, bool bWarnAboutRenaming = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = ActorsToMove?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestStreamingLevel?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bWarnAboutReferences;

				*(bool*)(__InBuffer + 17) = bWarnAboutRenaming;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MoveActorsToLevel, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true	If a level was removed.
		/// </returns>
		public static void MakeLevelCurrent(ULevelStreaming InStreamingLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStreamingLevel?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __MakeLevelCurrent, __InBuffer);
			}
		}

		/// <param name="InWorld">
		/// World in which to add the level.
		/// </param>
		/// <param name="LevelPackageName">
		/// The package name ("e.g /Game/MyLevel") of the level package to add.
		/// </param>
		/// <param name="LevelStreamingClass">
		/// The streaming class type to use for the level.
		/// </param>
		/// <param name="LevelTransform">
		/// The origin of the new level in the world.
		/// </param>
		/// <returns>
		/// The new level, or NULL if the level couldn't added.
		/// </returns>
		public static ULevelStreaming K2_AddLevelToWorldWithTransform(UWorld World, FString LevelPackageName, TSubclassOf<ULevelStreaming> LevelStreamingClass, FTransform LevelTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelPackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LevelStreamingClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LevelTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_AddLevelToWorldWithTransform, __InBuffer, __ReturnBuffer);

				return *(ULevelStreaming*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// World in which to add the level.
		/// </param>
		/// <param name="LevelPackageName">
		/// The package name ("e.g /Game/MyLevel") of the level package to add.
		/// </param>
		/// <param name="LevelStreamingClass">
		/// The streaming class type to use for the level.
		/// </param>
		/// <returns>
		/// The new level, or NULL if the level couldn't added.
		/// </returns>
		public static ULevelStreaming K2_AddLevelToWorld(UWorld World, FString LevelPackageName, TSubclassOf<ULevelStreaming> LevelStreamingClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelPackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LevelStreamingClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_AddLevelToWorld, __InBuffer, __ReturnBuffer);

				return *(ULevelStreaming*)__ReturnBuffer;
			}
		}

		/// <param name="World">
		/// World containing levels
		/// </param>
		/// <returns>
		/// Set of all levels
		/// </returns>
		public static TArray<ULevel> GetLevels(UWorld World)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLevels, __InBuffer, __ReturnBuffer);

				return *(TArray<ULevel>*)__ReturnBuffer;
			}
		}

		/// <param name="LevelStreamingClass">
		/// The streaming class type instead to use for the level.
		/// </param>
		/// <param name="NewLevelPath">
		/// Optional path to the level package path format ("e.g /Game/MyLevel").  If empty, the user will be prompted during the save process.
		/// </param>
		/// <param name="bMoveSelectedActorsIntoNewLevel">
		/// If true, move any selected actors into the new level.
		/// </param>
		/// <returns>
		/// Returns the newly created level, or NULL on failure
		/// </returns>
		public static ULevelStreaming CreateNewStreamingLevel(TSubclassOf<ULevelStreaming> LevelStreamingClass, FString NewLevelPath = null, bool bMoveSelectedActorsIntoNewLevel = false)
		{
			unsafe
			{
				NewLevelPath ??= new FString("");

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = LevelStreamingClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewLevelPath?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bMoveSelectedActorsIntoNewLevel;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNewStreamingLevel, __InBuffer, __ReturnBuffer);

				return *(ULevelStreaming*)__ReturnBuffer;
			}
		}

		private static uint __SetLevelVisibility = 0;

		private static uint __SetLevelsVisibility = 0;

		private static uint __MoveSelectedActorsToLevel = 0;

		private static uint __MoveActorsToLevel = 0;

		private static uint __MakeLevelCurrent = 0;

		private static uint __K2_AddLevelToWorldWithTransform = 0;

		private static uint __K2_AddLevelToWorld = 0;

		private static uint __GetLevels = 0;

		private static uint __CreateNewStreamingLevel = 0;
	}
}