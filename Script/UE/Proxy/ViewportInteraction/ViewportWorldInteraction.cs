using Script.CoreUObject;
using Script.UnrealEd;
using Script.Engine;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportWorldInteraction")]
	public partial class UViewportWorldInteraction : UEditorWorldExtension, IStaticClass
	{
		public TArray<UViewportInteractor> Interactors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Interactors, __ReturnBuffer);

					return *(TArray<UViewportInteractor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Interactors, __InBuffer);
				}
			}
		}

		public UViewportTransformer ViewportTransformer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportTransformer, __ReturnBuffer);

					return *(UViewportTransformer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportTransformer, __InBuffer);
				}
			}
		}

		public ABaseTransformGizmo TransformGizmoActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformGizmoActor, __ReturnBuffer);

					return *(ABaseTransformGizmo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformGizmoActor, __InBuffer);
				}
			}
		}

		public AActor SnapGridActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapGridActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapGridActor, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent SnapGridMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapGridMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapGridMeshComponent, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic SnapGridMID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SnapGridMID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SnapGridMID, __InBuffer);
				}
			}
		}

		public UMouseCursorInteractor DefaultMouseCursorInteractor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMouseCursorInteractor, __ReturnBuffer);

					return *(UMouseCursorInteractor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMouseCursorInteractor, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<AActor>> ActorsToExcludeFromHitTest
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorsToExcludeFromHitTest, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<AActor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorsToExcludeFromHitTest, __InBuffer);
				}
			}
		}

		public UViewportInteractionAssetContainer AssetContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetContainer, __ReturnBuffer);

					return *(UViewportInteractionAssetContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetContainer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ViewportWorldInteraction");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWorldToMetersScale(float NewWorldToMetersScale, bool bCompensateRoomWorldScale = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = NewWorldToMetersScale;

				*(bool*)(__InBuffer + 4) = bCompensateRoomWorldScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWorldToMetersScale, __InBuffer);
			}
		}

		public virtual void SetRoomTransformForNextFrame(FTransform NewRoomTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewRoomTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRoomTransformForNextFrame, __InBuffer);
			}
		}

		public virtual void SetHeadTransform(FTransform NewHeadTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewHeadTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHeadTransform, __InBuffer);
			}
		}

		public virtual void RemoveInteractor(UViewportInteractor Interactor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interactor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveInteractor, __InBuffer);
			}
		}

		public virtual float GetWorldScaleFactor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetWorldScaleFactor, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual ABaseTransformGizmo GetTransformGizmoActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTransformGizmoActor, __ReturnBuffer);

				return *(ABaseTransformGizmo*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRoomTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRoomTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRoomSpaceHeadTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRoomSpaceHeadTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual TArray<UViewportInteractor> GetInteractors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInteractors, __ReturnBuffer);

				return *(TArray<UViewportInteractor>*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetHeadTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHeadTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual void AddInteractor(UViewportInteractor Interactor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interactor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddInteractor, __InBuffer);
			}
		}

		/// <param name="ActorToExcludeFromHitTests">
		/// The actor that should be forever excluded from hit tests
		/// </param>
		public virtual void AddActorToExcludeFromHitTests(AActor ActorToExcludeFromHitTests)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorToExcludeFromHitTests?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddActorToExcludeFromHitTests, __InBuffer);
			}
		}

		private static uint __Interactors = 0;

		private static uint __ViewportTransformer = 0;

		private static uint __TransformGizmoActor = 0;

		private static uint __SnapGridActor = 0;

		private static uint __SnapGridMeshComponent = 0;

		private static uint __SnapGridMID = 0;

		private static uint __DefaultMouseCursorInteractor = 0;

		private static uint __ActorsToExcludeFromHitTest = 0;

		private static uint __AssetContainer = 0;

		private static uint __SetWorldToMetersScale = 0;

		private static uint __SetRoomTransformForNextFrame = 0;

		private static uint __SetHeadTransform = 0;

		private static uint __RemoveInteractor = 0;

		private static uint __GetWorldScaleFactor = 0;

		private static uint __GetTransformGizmoActor = 0;

		private static uint __GetRoomTransform = 0;

		private static uint __GetRoomSpaceHeadTransform = 0;

		private static uint __GetInteractors = 0;

		private static uint __GetHeadTransform = 0;

		private static uint __AddInteractor = 0;

		private static uint __AddActorToExcludeFromHitTests = 0;
	}
}