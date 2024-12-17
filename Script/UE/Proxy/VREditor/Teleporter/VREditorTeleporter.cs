using Script.CoreUObject;
using Script.Engine;
using Script.ViewportInteraction;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorTeleporter")]
	public partial class AVREditorTeleporter : AActor, IStaticClass
	{
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

		public UStaticMeshComponent TeleportDirectionMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportDirectionMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportDirectionMeshComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent HMDMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HMDMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HMDMeshComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent LeftMotionControllerMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LeftMotionControllerMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LeftMotionControllerMeshComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent RightMotionControllerMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RightMotionControllerMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RightMotionControllerMeshComponent, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic TeleportMID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportMID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportMID, __InBuffer);
				}
			}
		}

		public UViewportInteractor InteractorTryingTeleport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InteractorTryingTeleport, __ReturnBuffer);

					return *(UViewportInteractor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InteractorTryingTeleport, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorTeleporter");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void TeleportDone()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __TeleportDone);
			}
		}

		public virtual void StopAiming()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopAiming);
			}
		}

		public virtual void StartTeleport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartTeleport);
			}
		}

		public virtual void StartAiming(UViewportInteractor Interactor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interactor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartAiming, __InBuffer);
			}
		}

		public virtual void Shutdown()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Shutdown);
			}
		}

		public virtual void SetVisibility(bool bVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisibility, __InBuffer);
			}
		}

		public virtual void SetColor(FLinearColor Color)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Color?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColor, __InBuffer);
			}
		}

		public virtual bool IsTeleporting()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTeleporting, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAiming()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAiming, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void Init(UVREditorMode InMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMode?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Init, __InBuffer);
			}
		}

		public virtual UVREditorMode GetVRMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetVRMode, __ReturnBuffer);

				return *(UVREditorMode*)__ReturnBuffer;
			}
		}

		public virtual float GetSlideDelta(UVREditorInteractor Interactor, bool Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Interactor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Axis;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSlideDelta, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UViewportInteractor GetInteractorTryingTeleport()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInteractorTryingTeleport, __ReturnBuffer);

				return *(UViewportInteractor*)__ReturnBuffer;
			}
		}

		public virtual void DoTeleport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DoTeleport);
			}
		}

		private static uint __VRMode = 0;

		private static uint __TeleportDirectionMeshComponent = 0;

		private static uint __HMDMeshComponent = 0;

		private static uint __LeftMotionControllerMeshComponent = 0;

		private static uint __RightMotionControllerMeshComponent = 0;

		private static uint __TeleportMID = 0;

		private static uint __InteractorTryingTeleport = 0;

		private static uint __TeleportDone = 0;

		private static uint __StopAiming = 0;

		private static uint __StartTeleport = 0;

		private static uint __StartAiming = 0;

		private static uint __Shutdown = 0;

		private static uint __SetVisibility = 0;

		private static uint __SetColor = 0;

		private static uint __IsTeleporting = 0;

		private static uint __IsAiming = 0;

		private static uint __Init = 0;

		private static uint __GetVRMode = 0;

		private static uint __GetSlideDelta = 0;

		private static uint __GetInteractorTryingTeleport = 0;

		private static uint __DoTeleport = 0;
	}
}