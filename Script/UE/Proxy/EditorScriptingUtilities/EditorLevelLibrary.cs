using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.StaticMeshEditor;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorLevelLibrary")]
	public partial class UEditorLevelLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorLevelLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static AActor SpawnActorFromObject(UObject ObjectToUse, FVector Location, FRotator Rotation = null, bool bTransient = false)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = ObjectToUse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bTransient;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnActorFromObject, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static AActor SpawnActorFromClass(TSubclassOf<AActor> ActorClass, FVector Location, FRotator Rotation = null, bool bTransient = false)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bTransient;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnActorFromClass, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static void SetSelectedLevelActors(TArray<AActor> ActorsToSelect)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorsToSelect?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSelectedLevelActors, __InBuffer);
			}
		}

		public static void SetLevelViewportCameraInfo(FVector CameraLocation, FRotator CameraRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CameraRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLevelViewportCameraInfo, __InBuffer);
			}
		}

		public static bool SetCurrentLevelByName(FName LevelName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetCurrentLevelByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldBeSelected;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetActorSelectionState, __InBuffer);
			}
		}

		public static void SelectNothing()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __SelectNothing);
			}
		}

		public static bool SaveCurrentLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __SaveCurrentLevel, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SaveAllDirtyLevels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __SaveAllDirtyLevels, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void ReplaceSelectedActors(FString InAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceSelectedActors, __InBuffer);
			}
		}

		public static void ReplaceMeshComponentsMeshesOnActors(TArray<AActor> Actors, UStaticMesh MeshToBeReplaced, UStaticMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceMeshComponentsMeshesOnActors, __InBuffer);
			}
		}

		public static void ReplaceMeshComponentsMeshes(TArray<UStaticMeshComponent> MeshComponents, UStaticMesh MeshToBeReplaced, UStaticMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MeshComponents?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceMeshComponentsMeshes, __InBuffer);
			}
		}

		public static void ReplaceMeshComponentsMaterialsOnActors(TArray<AActor> Actors, UMaterialInterface MaterialToBeReplaced, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceMeshComponentsMaterialsOnActors, __InBuffer);
			}
		}

		public static void ReplaceMeshComponentsMaterials(TArray<UMeshComponent> MeshComponents, UMaterialInterface MaterialToBeReplaced, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MeshComponents?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceMeshComponentsMaterials, __InBuffer);
			}
		}

		public static void PilotLevelActor(AActor ActorToPilot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorToPilot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PilotLevelActor, __InBuffer);
			}
		}

		public static bool NewLevelFromTemplate(FString AssetPath, FString TemplateAssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TemplateAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NewLevelFromTemplate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NewLevel(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NewLevel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool MergeStaticMeshActors(TArray<AStaticMeshActor> ActorsToMerge, FMergeStaticMeshActorsOptions MergeOptions, ref AStaticMeshActor OutMergedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ActorsToMerge?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MergeOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutMergedActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __MergeStaticMeshActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMergedActor = *(AStaticMeshActor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool LoadLevel(FString AssetPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadLevel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static AActor JoinStaticMeshActors(TArray<AStaticMeshActor> ActorsToJoin, FJoinStaticMeshActorsOptions JoinOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ActorsToJoin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = JoinOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __JoinStaticMeshActors, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static TArray<AActor> GetSelectedLevelActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSelectedLevelActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public static TArray<UWorld> GetPIEWorlds(bool bIncludeDedicatedServer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIncludeDedicatedServer;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPIEWorlds, __InBuffer, __ReturnBuffer);

				return *(TArray<UWorld>*)__ReturnBuffer;
			}
		}

		public static bool GetLevelViewportCameraInfo(ref FVector CameraLocation, ref FRotator CameraRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CameraRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetLevelViewportCameraInfo, __InBuffer, __OutBuffer, __ReturnBuffer);

				CameraLocation = *(FVector*)(__OutBuffer);

				CameraRotation = *(FRotator*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UWorld GetGameWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGameWorld, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public static UWorld GetEditorWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEditorWorld, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		public static TArray<UActorComponent> GetAllLevelActorsComponents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllLevelActorsComponents, __ReturnBuffer);

				return *(TArray<UActorComponent>*)__ReturnBuffer;
			}
		}

		public static TArray<AActor> GetAllLevelActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllLevelActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public static AActor GetActorReference(FString PathToActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathToActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetActorReference, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static void EjectPilotLevelActor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EjectPilotLevelActor);
			}
		}

		public static void EditorSetGameView(bool bGameView)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bGameView;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EditorSetGameView, __InBuffer);
			}
		}

		public static void EditorPlaySimulate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EditorPlaySimulate);
			}
		}

		public static void EditorInvalidateViewports()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EditorInvalidateViewports);
			}
		}

		public static void EditorEndPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EditorEndPlay);
			}
		}

		public static bool DestroyActor(AActor ActorToDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorToDestroy?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DestroyActor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CreateProxyMeshActor(TArray<AStaticMeshActor> ActorsToMerge, FCreateProxyMeshActorOptions MergeOptions, ref AStaticMeshActor OutMergedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ActorsToMerge?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MergeOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutMergedActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyMeshActor, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMergedActor = *(AStaticMeshActor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<AActor> ConvertActors(TArray<AActor> Actors, TSubclassOf<AActor> ActorClass, FString StaticMeshPackagePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StaticMeshPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertActors, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public static void ClearActorSelectionSet()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ClearActorSelectionSet);
			}
		}

		private static uint __SpawnActorFromObject = 0;

		private static uint __SpawnActorFromClass = 0;

		private static uint __SetSelectedLevelActors = 0;

		private static uint __SetLevelViewportCameraInfo = 0;

		private static uint __SetCurrentLevelByName = 0;

		private static uint __SetActorSelectionState = 0;

		private static uint __SelectNothing = 0;

		private static uint __SaveCurrentLevel = 0;

		private static uint __SaveAllDirtyLevels = 0;

		private static uint __ReplaceSelectedActors = 0;

		private static uint __ReplaceMeshComponentsMeshesOnActors = 0;

		private static uint __ReplaceMeshComponentsMeshes = 0;

		private static uint __ReplaceMeshComponentsMaterialsOnActors = 0;

		private static uint __ReplaceMeshComponentsMaterials = 0;

		private static uint __PilotLevelActor = 0;

		private static uint __NewLevelFromTemplate = 0;

		private static uint __NewLevel = 0;

		private static uint __MergeStaticMeshActors = 0;

		private static uint __LoadLevel = 0;

		private static uint __JoinStaticMeshActors = 0;

		private static uint __GetSelectedLevelActors = 0;

		private static uint __GetPIEWorlds = 0;

		private static uint __GetLevelViewportCameraInfo = 0;

		private static uint __GetGameWorld = 0;

		private static uint __GetEditorWorld = 0;

		private static uint __GetAllLevelActorsComponents = 0;

		private static uint __GetAllLevelActors = 0;

		private static uint __GetActorReference = 0;

		private static uint __EjectPilotLevelActor = 0;

		private static uint __EditorSetGameView = 0;

		private static uint __EditorPlaySimulate = 0;

		private static uint __EditorInvalidateViewports = 0;

		private static uint __EditorEndPlay = 0;

		private static uint __DestroyActor = 0;

		private static uint __CreateProxyMeshActor = 0;

		private static uint __ConvertActors = 0;

		private static uint __ClearActorSelectionSet = 0;
	}
}