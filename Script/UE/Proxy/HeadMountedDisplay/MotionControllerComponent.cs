using Script.CoreUObject;
using Script.Engine;
using Script.InputCore;
using Script.Library;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.MotionControllerComponent")]
	public partial class UMotionControllerComponent : UPrimitiveComponent, IStaticClass
	{
		public int PlayerIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerIndex, __InBuffer);
				}
			}
		}

		public FName MotionSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MotionSource, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MotionSource, __InBuffer);
				}
			}
		}

		public bool bDisableLowLatencyUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableLowLatencyUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableLowLatencyUpdate, __InBuffer);
				}
			}
		}

		public ETrackingStatus CurrentTrackingStatus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTrackingStatus, __ReturnBuffer);

					return *(ETrackingStatus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTrackingStatus, __InBuffer);
				}
			}
		}

		public bool bDisplayDeviceModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisplayDeviceModel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisplayDeviceModel, __InBuffer);
				}
			}
		}

		public FName DisplayModelSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayModelSource, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayModelSource, __InBuffer);
				}
			}
		}

		public UStaticMesh CustomDisplayMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDisplayMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDisplayMesh, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> DisplayMeshMaterialOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayMeshMaterialOverrides, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayMeshMaterialOverrides, __InBuffer);
				}
			}
		}

		public UPrimitiveComponent DisplayComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayComponent, __ReturnBuffer);

					return *(UPrimitiveComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HeadMountedDisplay.MotionControllerComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTrackingSource(EControllerHand NewSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewSource;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTrackingSource, __InBuffer);
			}
		}

		public virtual void SetTrackingMotionSource(FName NewSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewSource?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTrackingMotionSource, __InBuffer);
			}
		}

		public virtual void SetShowDeviceModel(bool bShowControllerModel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShowControllerModel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShowDeviceModel, __InBuffer);
			}
		}

		public virtual void SetDisplayModelSource(FName NewDisplayModelSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewDisplayModelSource?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisplayModelSource, __InBuffer);
			}
		}

		public virtual void SetCustomDisplayMesh(UStaticMesh NewDisplayMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewDisplayMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomDisplayMesh, __InBuffer);
			}
		}

		public virtual void SetAssociatedPlayerIndex(int NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewPlayer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAssociatedPlayerIndex, __InBuffer);
			}
		}

		public virtual void OnMotionControllerUpdated()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnMotionControllerUpdated);
			}
		}

		public virtual bool IsTracked()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTracked, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EControllerHand GetTrackingSource()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTrackingSource, __ReturnBuffer);

				return *(EControllerHand*)__ReturnBuffer;
			}
		}

		public virtual float GetParameterValue(FName InName, ref bool bValueFound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bValueFound;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetParameterValue, __InBuffer, __OutBuffer, __ReturnBuffer);

				bValueFound = *(bool*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool GetLinearVelocity(ref FVector OutLinearVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutLinearVelocity?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLinearVelocity, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutLinearVelocity = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetLinearAcceleration(ref FVector OutLinearAcceleration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutLinearAcceleration?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLinearAcceleration, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutLinearAcceleration = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetHandJointPosition(int jointIndex, ref bool bValueFound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = jointIndex;

				*(bool*)(__InBuffer + 4) = bValueFound;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetHandJointPosition, __InBuffer, __OutBuffer, __ReturnBuffer);

				bValueFound = *(bool*)(__OutBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual bool GetAngularVelocity(ref FRotator OutAngularVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutAngularVelocity?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAngularVelocity, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAngularVelocity = *(FRotator*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __PlayerIndex = 0;

		private static uint __MotionSource = 0;

		private static uint __bDisableLowLatencyUpdate = 0;

		private static uint __CurrentTrackingStatus = 0;

		private static uint __bDisplayDeviceModel = 0;

		private static uint __DisplayModelSource = 0;

		private static uint __CustomDisplayMesh = 0;

		private static uint __DisplayMeshMaterialOverrides = 0;

		private static uint __DisplayComponent = 0;

		private static uint __SetTrackingSource = 0;

		private static uint __SetTrackingMotionSource = 0;

		private static uint __SetShowDeviceModel = 0;

		private static uint __SetDisplayModelSource = 0;

		private static uint __SetCustomDisplayMesh = 0;

		private static uint __SetAssociatedPlayerIndex = 0;

		private static uint __OnMotionControllerUpdated = 0;

		private static uint __IsTracked = 0;

		private static uint __GetTrackingSource = 0;

		private static uint __GetParameterValue = 0;

		private static uint __GetLinearVelocity = 0;

		private static uint __GetLinearAcceleration = 0;

		private static uint __GetHandJointPosition = 0;

		private static uint __GetAngularVelocity = 0;
	}
}