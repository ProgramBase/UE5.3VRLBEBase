using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;
using Script.TypedElementRuntime;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.LevelEditorSubsystem")]
	public partial class ULevelEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public FOnLevelEditorPreSaveWorld OnPreSaveWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreSaveWorld, __ReturnBuffer);

					return *(FOnLevelEditorPreSaveWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPreSaveWorld, __InBuffer);
				}
			}
		}

		public FOnLevelEditorPostSaveWorld OnPostSaveWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostSaveWorld, __ReturnBuffer);

					return *(FOnLevelEditorPostSaveWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPostSaveWorld, __InBuffer);
				}
			}
		}

		public FOnLevelEditorEditorCameraMoved OnEditorCameraMoved
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditorCameraMoved, __ReturnBuffer);

					return *(FOnLevelEditorEditorCameraMoved*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditorCameraMoved, __InBuffer);
				}
			}
		}

		public FOnLevelEditorMapChanged OnMapChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMapChanged, __ReturnBuffer);

					return *(FOnLevelEditorMapChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMapChanged, __InBuffer);
				}
			}
		}

		public FOnLevelEditorMapOpened OnMapOpened
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMapOpened, __ReturnBuffer);

					return *(FOnLevelEditorMapOpened*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMapOpened, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.LevelEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="LevelName">
		/// The name of the Level the actor belongs to (same name as in the ContentBrowser).
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SetCurrentLevelByName(FName LevelName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurrentLevelByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetAllowsCinematicControl(bool bAllow, FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bAllow;

				*(nint*)(__InBuffer + 1) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowsCinematicControl, __InBuffer);
			}
		}

		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SaveCurrentLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SaveCurrentLevel, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool SaveAllDirtyLevels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SaveAllDirtyLevels, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void PilotLevelActor(AActor ActorToPilot, FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ActorToPilot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PilotLevelActor, __InBuffer);
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of where the level will be saved.
		/// ie. /Game/MyFolder/MyAsset
		/// </param>
		/// <param name="TemplateAssetPath">
		/// Level to be used as Template.
		/// ie. /Game/MyFolder/MyAsset
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool NewLevelFromTemplate(FString AssetPath, FString TemplateAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TemplateAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __NewLevelFromTemplate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of where the level will be saved.
		/// ie. /Game/MyFolder/MyAsset
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool NewLevel(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __NewLevel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AssetPath">
		/// Asset Path of the level to be loaded.
		/// ie. /Game/MyFolder/MyAsset
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool LoadLevel(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __LoadLevel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInPlayInEditor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInPlayInEditor, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetViewportConfigKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewportConfigKeys, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual UTypedElementSelectionSet GetSelectionSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectionSet, __ReturnBuffer);

				return *(UTypedElementSelectionSet*)__ReturnBuffer;
			}
		}

		public virtual AActor GetPilotLevelActor(FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetPilotLevelActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The current level
		/// </returns>
		public virtual ULevel GetCurrentLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentLevel, __ReturnBuffer);

				return *(ULevel*)__ReturnBuffer;
			}
		}

		public virtual bool GetAllowsCinematicControl(FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetAllowsCinematicControl, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName GetActiveViewportConfigKey()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActiveViewportConfigKey, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual void EjectPilotLevelActor(FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EjectPilotLevelActor, __InBuffer);
			}
		}

		public virtual void EditorSetGameView(bool bGameView, FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bGameView;

				*(nint*)(__InBuffer + 1) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EditorSetGameView, __InBuffer);
			}
		}

		public virtual void EditorRequestEndPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EditorRequestEndPlay);
			}
		}

		public virtual void EditorPlaySimulate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EditorPlaySimulate);
			}
		}

		public virtual void EditorInvalidateViewports()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EditorInvalidateViewports);
			}
		}

		public virtual bool EditorGetGameView(FName ViewportConfigKey = null)
		{
			unsafe
			{
				ViewportConfigKey ??= new FName("None");

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ViewportConfigKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __EditorGetGameView, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Quality">
		/// One of the enum LightingBuildQuality value. Default is Quality_Production.
		/// </param>
		/// <param name="bWithReflectionCaptures">
		/// Build the related reflection captures after building the light maps.
		/// </param>
		/// <returns>
		/// True if build was successful.
		/// </returns>
		public virtual bool BuildLightMaps(ELightingBuildQuality Quality = ELightingBuildQuality.Quality_Production, bool bWithReflectionCaptures = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)Quality;

				*(bool*)(__InBuffer + 1) = bWithReflectionCaptures;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BuildLightMaps, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __OnPreSaveWorld = 0;

		private static uint __OnPostSaveWorld = 0;

		private static uint __OnEditorCameraMoved = 0;

		private static uint __OnMapChanged = 0;

		private static uint __OnMapOpened = 0;

		private static uint __SetCurrentLevelByName = 0;

		private static uint __SetAllowsCinematicControl = 0;

		private static uint __SaveCurrentLevel = 0;

		private static uint __SaveAllDirtyLevels = 0;

		private static uint __PilotLevelActor = 0;

		private static uint __NewLevelFromTemplate = 0;

		private static uint __NewLevel = 0;

		private static uint __LoadLevel = 0;

		private static uint __IsInPlayInEditor = 0;

		private static uint __GetViewportConfigKeys = 0;

		private static uint __GetSelectionSet = 0;

		private static uint __GetPilotLevelActor = 0;

		private static uint __GetCurrentLevel = 0;

		private static uint __GetAllowsCinematicControl = 0;

		private static uint __GetActiveViewportConfigKey = 0;

		private static uint __EjectPilotLevelActor = 0;

		private static uint __EditorSetGameView = 0;

		private static uint __EditorRequestEndPlay = 0;

		private static uint __EditorPlaySimulate = 0;

		private static uint __EditorInvalidateViewports = 0;

		private static uint __EditorGetGameView = 0;

		private static uint __BuildLightMaps = 0;
	}
}