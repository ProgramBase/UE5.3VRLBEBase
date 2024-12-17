using Script.CoreUObject;
using Script.ViewportInteraction;
using Script.HeadMountedDisplay;
using Script.Engine;
using Script.Library;
using Script.InputCore;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorInteractor")]
	public partial class UVREditorInteractor : UViewportInteractor, IStaticClass
	{
		public bool bIsUndoRedoSwipeEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsUndoRedoSwipeEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsUndoRedoSwipeEnabled, __InBuffer);
				}
			}
		}

		public UMotionControllerComponent MotionControllerComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MotionControllerComponent, __ReturnBuffer);

					return *(UMotionControllerComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MotionControllerComponent, __InBuffer);
				}
			}
		}

		public UMotionControllerComponent LaserMotionControllerComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LaserMotionControllerComponent, __ReturnBuffer);

					return *(UMotionControllerComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LaserMotionControllerComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent HandMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HandMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HandMeshComponent, __InBuffer);
				}
			}
		}

		public USplineComponent LaserSplineComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LaserSplineComponent, __ReturnBuffer);

					return *(USplineComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LaserSplineComponent, __InBuffer);
				}
			}
		}

		public TArray<USplineMeshComponent> LaserSplineMeshComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LaserSplineMeshComponents, __ReturnBuffer);

					return *(TArray<USplineMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LaserSplineMeshComponents, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic LaserPointerMID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LaserPointerMID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LaserPointerMID, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic TranslucentLaserPointerMID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentLaserPointerMID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentLaserPointerMID, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent HoverMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoverMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoverMeshComponent, __InBuffer);
				}
			}
		}

		public UPointLightComponent HoverPointLightComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoverPointLightComponent, __ReturnBuffer);

					return *(UPointLightComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoverPointLightComponent, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic HandMeshMID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HandMeshMID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HandMeshMID, __InBuffer);
				}
			}
		}

		public AActor OwningAvatar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningAvatar, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningAvatar, __InBuffer);
				}
			}
		}

		public EControllerType ControllerType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControllerType, __ReturnBuffer);

					return *(EControllerType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControllerType, __InBuffer);
				}
			}
		}

		public EControllerType OverrideControllerType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideControllerType, __ReturnBuffer);

					return *(EControllerType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideControllerType, __InBuffer);
				}
			}
		}

		public FName ControllerMotionSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControllerMotionSource, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControllerMotionSource, __InBuffer);
				}
			}
		}

		public UVREditorMode VRMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __ReturnBuffer);

					return *(UVREditorMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorInteractor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateHandMeshRelativeTransform()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UpdateHandMeshRelativeTransform);
			}
		}

		/// <returns>
		/// true if the controller type was changed
		/// </returns>
		public virtual bool TryOverrideControllerType(EControllerType InControllerType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InControllerType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __TryOverrideControllerType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetupComponent(AActor OwningActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwningActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetupComponent, __InBuffer);
			}
		}

		public virtual void SetForceShowLaser(bool bInForceShow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInForceShow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceShowLaser, __InBuffer);
			}
		}

		public virtual void SetForceLaserColor(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceLaserColor, __InBuffer);
			}
		}

		public virtual void SetControllerType(EControllerType InControllerType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InControllerType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControllerType, __InBuffer);
			}
		}

		public virtual void SetControllerHandSide(FName InControllerHandSide)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InControllerHandSide?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControllerHandSide, __InBuffer);
			}
		}

		public virtual void ReplaceHandMeshComponent(UStaticMesh NewMesh, FVector MeshScale = null)
		{
			unsafe
			{
				MeshScale ??= new FVector(1.000000, 1.000000, 1.000000);

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshScale?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceHandMeshComponent, __InBuffer);
			}
		}

		public virtual bool IsTouchingTrackpad()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTouchingTrackpad, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsHoveringOverUI()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHoveringOverUI, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsClickingOnUI()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsClickingOnUI, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void Init(UVREditorMode InVRMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVRMode?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Init, __InBuffer);
			}
		}

		public virtual FVector2D GetTrackpadPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTrackpadPosition, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual AVREditorTeleporter GetTeleportActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTeleportActor, __ReturnBuffer);

				return *(AVREditorTeleporter*)__ReturnBuffer;
			}
		}

		public virtual float GetSlideDelta()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSlideDelta, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetSelectAndMoveTriggerValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSelectAndMoveTriggerValue, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UMotionControllerComponent GetMotionControllerComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMotionControllerComponent, __ReturnBuffer);

				return *(UMotionControllerComponent*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetLastTrackpadPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastTrackpadPosition, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLaserStart()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLaserStart, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLaserEnd()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLaserEnd, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Returns the type of HMD we're dealing with */
		/// </returns>
		public virtual FName GetHMDDeviceType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHMDDeviceType, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual EControllerType GetControllerType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetControllerType, __ReturnBuffer);

				return *(EControllerType*)__ReturnBuffer;
			}
		}

		public virtual EControllerHand GetControllerSide()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetControllerSide, __ReturnBuffer);

				return *(EControllerHand*)__ReturnBuffer;
			}
		}

		public virtual FName GetControllerHandSide()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControllerHandSide, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __bIsUndoRedoSwipeEnabled = 0;

		private static uint __MotionControllerComponent = 0;

		private static uint __LaserMotionControllerComponent = 0;

		private static uint __HandMeshComponent = 0;

		private static uint __LaserSplineComponent = 0;

		private static uint __LaserSplineMeshComponents = 0;

		private static uint __LaserPointerMID = 0;

		private static uint __TranslucentLaserPointerMID = 0;

		private static uint __HoverMeshComponent = 0;

		private static uint __HoverPointLightComponent = 0;

		private static uint __HandMeshMID = 0;

		private static uint __OwningAvatar = 0;

		private static uint __ControllerType = 0;

		private static uint __OverrideControllerType = 0;

		private static uint __ControllerMotionSource = 0;

		private static uint __VRMode = 0;

		private static uint __UpdateHandMeshRelativeTransform = 0;

		private static uint __TryOverrideControllerType = 0;

		private static uint __SetupComponent = 0;

		private static uint __SetForceShowLaser = 0;

		private static uint __SetForceLaserColor = 0;

		private static uint __SetControllerType = 0;

		private static uint __SetControllerHandSide = 0;

		private static uint __ReplaceHandMeshComponent = 0;

		private static uint __IsTouchingTrackpad = 0;

		private static uint __IsHoveringOverUI = 0;

		private static uint __IsClickingOnUI = 0;

		private static uint __Init = 0;

		private static uint __GetTrackpadPosition = 0;

		private static uint __GetTeleportActor = 0;

		private static uint __GetSlideDelta = 0;

		private static uint __GetSelectAndMoveTriggerValue = 0;

		private static uint __GetMotionControllerComponent = 0;

		private static uint __GetLastTrackpadPosition = 0;

		private static uint __GetLaserStart = 0;

		private static uint __GetLaserEnd = 0;

		private static uint __GetHMDDeviceType = 0;

		private static uint __GetControllerType = 0;

		private static uint __GetControllerSide = 0;

		private static uint __GetControllerHandSide = 0;
	}
}