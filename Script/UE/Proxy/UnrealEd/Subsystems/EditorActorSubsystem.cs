using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorActorSubsystem")]
	public partial class UEditorActorSubsystem : UEditorSubsystem, IStaticClass
	{
		public FOnEditNewActorsDropped OnNewActorsDropped
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNewActorsDropped, __ReturnBuffer);

					return *(FOnEditNewActorsDropped*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNewActorsDropped, __InBuffer);
				}
			}
		}

		public FOnEditNewActorsPlaced OnNewActorsPlaced
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNewActorsPlaced, __ReturnBuffer);

					return *(FOnEditNewActorsPlaced*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNewActorsPlaced, __InBuffer);
				}
			}
		}

		public FOnEditCutActorsBegin OnEditCutActorsBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCutActorsBegin, __ReturnBuffer);

					return *(FOnEditCutActorsBegin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCutActorsBegin, __InBuffer);
				}
			}
		}

		public FOnEditCutActorsEnd OnEditCutActorsEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCutActorsEnd, __ReturnBuffer);

					return *(FOnEditCutActorsEnd*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCutActorsEnd, __InBuffer);
				}
			}
		}

		public FOnEditCopyActorsBegin OnEditCopyActorsBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCopyActorsBegin, __ReturnBuffer);

					return *(FOnEditCopyActorsBegin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCopyActorsBegin, __InBuffer);
				}
			}
		}

		public FOnEditCopyActorsEnd OnEditCopyActorsEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCopyActorsEnd, __ReturnBuffer);

					return *(FOnEditCopyActorsEnd*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditCopyActorsEnd, __InBuffer);
				}
			}
		}

		public FOnEditPasteActorsBegin OnEditPasteActorsBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditPasteActorsBegin, __ReturnBuffer);

					return *(FOnEditPasteActorsBegin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditPasteActorsBegin, __InBuffer);
				}
			}
		}

		public FOnEditPasteActorsEnd OnEditPasteActorsEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditPasteActorsEnd, __ReturnBuffer);

					return *(FOnEditPasteActorsEnd*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEditPasteActorsEnd, __InBuffer);
				}
			}
		}

		public FOnEditCutActorsBegin OnDuplicateActorsBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDuplicateActorsBegin, __ReturnBuffer);

					return *(FOnEditCutActorsBegin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDuplicateActorsBegin, __InBuffer);
				}
			}
		}

		public FOnDuplicateActorsEnd OnDuplicateActorsEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDuplicateActorsEnd, __ReturnBuffer);

					return *(FOnDuplicateActorsEnd*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDuplicateActorsEnd, __InBuffer);
				}
			}
		}

		public FOnDeleteActorsBegin OnDeleteActorsBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDeleteActorsBegin, __ReturnBuffer);

					return *(FOnDeleteActorsBegin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDeleteActorsBegin, __InBuffer);
				}
			}
		}

		public FOnDeleteActorsEnd OnDeleteActorsEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDeleteActorsEnd, __ReturnBuffer);

					return *(FOnDeleteActorsEnd*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDeleteActorsEnd, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorActorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="ObjectToUse">
		/// Asset to attempt to use for an actor to place.
		/// </param>
		/// <param name="Location">
		/// Location of the new actor.
		/// </param>
		/// <returns>
		/// The created actor.
		/// </returns>
		public virtual AActor SpawnActorFromObject(UObject ObjectToUse, FVector Location, FRotator Rotation = null, bool bTransient = false)
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

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SpawnActorFromObject, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="ActorClass">
		/// Asset to attempt to use for an actor to place.
		/// </param>
		/// <param name="Location">
		/// Location of the new actor.
		/// </param>
		/// <returns>
		/// The created actor.
		/// </returns>
		public virtual AActor SpawnActorFromClass(TSubclassOf<AActor> ActorClass, FVector Location, FRotator Rotation = null, bool bTransient = false)
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

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SpawnActorFromClass, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="ActorsToSelect">
		/// Actor that should be selected in the world editor.
		/// </param>
		public virtual void SetSelectedLevelActors(TArray<AActor> ActorsToSelect)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorsToSelect?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectedLevelActors, __InBuffer);
			}
		}

		/// <returns>
		/// false if the world transform could not be set.
		/// </returns>
		public virtual bool SetComponentTransform(USceneComponent InSceneComponent, FTransform InWorldTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSceneComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetComponentTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// false if the world transform could not be set.
		/// </returns>
		public virtual bool SetActorTransform(AActor InActor, FTransform InWorldTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetActorTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldBeSelected;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorSelectionState, __InBuffer);
			}
		}

		public virtual void SelectNothing()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SelectNothing);
			}
		}

		/// <param name="bRecurseChildren">
		/// True to recurse through all descendants of the children
		/// </param>
		public virtual void SelectAllChildren(bool bRecurseChildren)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRecurseChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SelectAllChildren, __InBuffer);
			}
		}

		/// <param name="InWorld">
		/// The world the actors are to be selected in.
		/// </param>
		public virtual void SelectAll(UWorld InWorld)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SelectAll, __InBuffer);
			}
		}

		/// <param name="InWorld">
		/// The world the selection is in.
		/// </param>
		public virtual void InvertSelection(UWorld InWorld)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InvertSelection, __InBuffer);
			}
		}

		/// <param name="ActorClass">
		/// Actor Class to find.
		/// </param>
		/// <returns>
		/// List of found Actors
		/// </returns>
		public virtual TArray<AActor> GetSelectedLevelActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedLevelActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// List of found ActorComponent
		/// </returns>
		public virtual TArray<UActorComponent> GetAllLevelActorsComponents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllLevelActorsComponents, __ReturnBuffer);

				return *(TArray<UActorComponent>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// List of found Actors
		/// </returns>
		public virtual TArray<AActor> GetAllLevelActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllLevelActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
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

		/// <param name="InWorld">
		/// The world the actors are selected in.
		/// </param>
		public virtual void DuplicateSelectedActors(UWorld InWorld)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DuplicateSelectedActors, __InBuffer);
			}
		}

		/// <param name="ActorsToDuplicate">
		/// Actors to duplicate.
		/// </param>
		/// <param name="ToWorld">
		/// World to place the duplicated actors in.
		/// </param>
		/// <param name="Offset">
		/// Translation to offset duplicated actors by.
		/// </param>
		/// <returns>
		/// The duplicated actors, or empty if it didn't succeed
		/// </returns>
		public virtual TArray<AActor> DuplicateActors(TArray<AActor> ActorsToDuplicate, UWorld ToWorld = null, FVector Offset = null)
		{
			unsafe
			{
				Offset ??= new FVector();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ActorsToDuplicate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Offset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateActors, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="ActorToDuplicate">
		/// Actor to duplicate.
		/// </param>
		/// <param name="ToWorld">
		/// World to place the duplicated actor in.
		/// </param>
		/// <param name="Offset">
		/// Translation to offset duplicated actor by.
		/// </param>
		/// <returns>
		/// The duplicated actor, or none if it didn't succeed
		/// </returns>
		public virtual AActor DuplicateActor(AActor ActorToDuplicate, UWorld ToWorld = null, FVector Offset = null)
		{
			unsafe
			{
				Offset ??= new FVector();

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ActorToDuplicate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Offset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __DuplicateActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="ActorsToDestroy">
		/// Actors to destroy.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool DestroyActors(TArray<AActor> ActorsToDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorsToDestroy?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DestroyActors, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ActorToDestroy">
		/// Actor to destroy.
		/// </param>
		/// <returns>
		/// True if the operation succeeds.
		/// </returns>
		public virtual bool DestroyActor(AActor ActorToDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorToDestroy?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DestroyActor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// The world the actors are selected in.
		/// </param>
		public virtual void DeleteSelectedActors(UWorld InWorld)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteSelectedActors, __InBuffer);
			}
		}

		/// <param name="Actors">
		/// List of Actors to replace.
		/// </param>
		/// <param name="ActorClass">
		/// Class/Blueprint of the new actor that will be spawn.
		/// </param>
		/// <param name="StaticMeshPackagePath">
		/// If the list contains Brushes and it is requested to change them to StaticMesh, StaticMeshPackagePath is the package path to where the StaticMesh will be created. ie. /Game/MyFolder/
		/// </param>
		public virtual TArray<AActor> ConvertActors(TArray<AActor> Actors, TSubclassOf<AActor> ActorClass, FString StaticMeshPackagePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = StaticMeshPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ConvertActors, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public virtual void ClearActorSelectionSet()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearActorSelectionSet);
			}
		}

		private static uint __OnNewActorsDropped = 0;

		private static uint __OnNewActorsPlaced = 0;

		private static uint __OnEditCutActorsBegin = 0;

		private static uint __OnEditCutActorsEnd = 0;

		private static uint __OnEditCopyActorsBegin = 0;

		private static uint __OnEditCopyActorsEnd = 0;

		private static uint __OnEditPasteActorsBegin = 0;

		private static uint __OnEditPasteActorsEnd = 0;

		private static uint __OnDuplicateActorsBegin = 0;

		private static uint __OnDuplicateActorsEnd = 0;

		private static uint __OnDeleteActorsBegin = 0;

		private static uint __OnDeleteActorsEnd = 0;

		private static uint __SpawnActorFromObject = 0;

		private static uint __SpawnActorFromClass = 0;

		private static uint __SetSelectedLevelActors = 0;

		private static uint __SetComponentTransform = 0;

		private static uint __SetActorTransform = 0;

		private static uint __SetActorSelectionState = 0;

		private static uint __SelectNothing = 0;

		private static uint __SelectAllChildren = 0;

		private static uint __SelectAll = 0;

		private static uint __InvertSelection = 0;

		private static uint __GetSelectedLevelActors = 0;

		private static uint __GetAllLevelActorsComponents = 0;

		private static uint __GetAllLevelActors = 0;

		private static uint __GetActorReference = 0;

		private static uint __DuplicateSelectedActors = 0;

		private static uint __DuplicateActors = 0;

		private static uint __DuplicateActor = 0;

		private static uint __DestroyActors = 0;

		private static uint __DestroyActor = 0;

		private static uint __DeleteSelectedActors = 0;

		private static uint __ConvertActors = 0;

		private static uint __ClearActorSelectionSet = 0;
	}
}