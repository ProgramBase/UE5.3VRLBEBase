using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MovementComponent")]
	public partial class UMovementComponent : UActorComponent, IStaticClass
	{
		public USceneComponent UpdatedComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdatedComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdatedComponent, __InBuffer);
				}
			}
		}

		public UPrimitiveComponent UpdatedPrimitive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdatedPrimitive, __ReturnBuffer);

					return *(UPrimitiveComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdatedPrimitive, __InBuffer);
				}
			}
		}

		public FVector Velocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Velocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Velocity, __InBuffer);
				}
			}
		}

		public FVector PlaneConstraintNormal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneConstraintNormal, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneConstraintNormal, __InBuffer);
				}
			}
		}

		public FVector PlaneConstraintOrigin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneConstraintOrigin, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneConstraintOrigin, __InBuffer);
				}
			}
		}

		public bool bUpdateOnlyIfRendered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateOnlyIfRendered, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateOnlyIfRendered, __InBuffer);
				}
			}
		}

		public bool bAutoUpdateTickRegistration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoUpdateTickRegistration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoUpdateTickRegistration, __InBuffer);
				}
			}
		}

		public bool bTickBeforeOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTickBeforeOwner, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTickBeforeOwner, __InBuffer);
				}
			}
		}

		public bool bAutoRegisterUpdatedComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRegisterUpdatedComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRegisterUpdatedComponent, __InBuffer);
				}
			}
		}

		public bool bConstrainToPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bConstrainToPlane, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bConstrainToPlane, __InBuffer);
				}
			}
		}

		public bool bSnapToPlaneAtStart
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSnapToPlaneAtStart, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSnapToPlaneAtStart, __InBuffer);
				}
			}
		}

		public bool bAutoRegisterPhysicsVolumeUpdates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRegisterPhysicsVolumeUpdates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRegisterPhysicsVolumeUpdates, __InBuffer);
				}
			}
		}

		public bool bComponentShouldUpdatePhysicsVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bComponentShouldUpdatePhysicsVolume, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bComponentShouldUpdatePhysicsVolume, __InBuffer);
				}
			}
		}

		public EPlaneConstraintAxisSetting PlaneConstraintAxisSetting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneConstraintAxisSetting, __ReturnBuffer);

					return *(EPlaneConstraintAxisSetting*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneConstraintAxisSetting, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MovementComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopMovementImmediately()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopMovementImmediately);
			}
		}

		public virtual void SnapUpdatedComponentToPlane()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SnapUpdatedComponentToPlane);
			}
		}

		public virtual void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewUpdatedComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUpdatedComponent, __InBuffer);
			}
		}

		public virtual void SetPlaneConstraintOrigin(FVector PlaneOrigin)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlaneOrigin?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaneConstraintOrigin, __InBuffer);
			}
		}

		/// <param name="PlaneNormal">
		/// The normal of the plane. If non-zero in length, it will be normalized.
		/// </param>
		public virtual void SetPlaneConstraintNormal(FVector PlaneNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlaneNormal?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaneConstraintNormal, __InBuffer);
			}
		}

		public virtual void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Forward?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Up?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaneConstraintFromVectors, __InBuffer);
			}
		}

		public virtual void SetPlaneConstraintEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaneConstraintEnabled, __InBuffer);
			}
		}

		/// <param name="NewAxisSetting">
		/// New plane constraint axis setting.
		/// </param>
		public virtual void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewAxisSetting;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaneConstraintAxisSetting, __InBuffer);
			}
		}

		public virtual void PhysicsVolumeChanged(APhysicsVolume NewVolume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewVolume?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PhysicsVolumeChanged, __InBuffer);
			}
		}

		/// <returns>
		/// True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit.
		/// </returns>
		public virtual bool K2_MoveUpdatedComponent(FVector Delta, FRotator NewRotation, ref FHitResult OutHit, bool bSweep, bool bTeleport)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = Delta?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSweep;

				*(bool*)(__InBuffer + 25) = bTeleport;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_MoveUpdatedComponent, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsExceedingMaxSpeed(float MaxSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = MaxSpeed;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsExceedingMaxSpeed, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The origin of the plane that constrains movement, if the plane constraint is enabled.
		/// </returns>
		public virtual FVector GetPlaneConstraintOrigin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlaneConstraintOrigin, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetPlaneConstraintNormal()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlaneConstraintNormal, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaneConstraintAxisSetting, __ReturnBuffer);

				return *(EPlaneConstraintAxisSetting*)__ReturnBuffer;
			}
		}

		public virtual APhysicsVolume GetPhysicsVolume()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPhysicsVolume, __ReturnBuffer);

				return *(APhysicsVolume*)__ReturnBuffer;
			}
		}

		public virtual float GetMaxSpeed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxSpeed, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetGravityZ()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGravityZ, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector ConstrainNormalToPlane(FVector Normal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ConstrainNormalToPlane, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector ConstrainLocationToPlane(FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ConstrainLocationToPlane, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetPlaneConstraint
		/// </see>
		public virtual FVector ConstrainDirectionToPlane(FVector Direction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ConstrainDirectionToPlane, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		private static uint __UpdatedComponent = 0;

		private static uint __UpdatedPrimitive = 0;

		private static uint __Velocity = 0;

		private static uint __PlaneConstraintNormal = 0;

		private static uint __PlaneConstraintOrigin = 0;

		private static uint __bUpdateOnlyIfRendered = 0;

		private static uint __bAutoUpdateTickRegistration = 0;

		private static uint __bTickBeforeOwner = 0;

		private static uint __bAutoRegisterUpdatedComponent = 0;

		private static uint __bConstrainToPlane = 0;

		private static uint __bSnapToPlaneAtStart = 0;

		private static uint __bAutoRegisterPhysicsVolumeUpdates = 0;

		private static uint __bComponentShouldUpdatePhysicsVolume = 0;

		private static uint __PlaneConstraintAxisSetting = 0;

		private static uint __StopMovementImmediately = 0;

		private static uint __SnapUpdatedComponentToPlane = 0;

		private static uint __SetUpdatedComponent = 0;

		private static uint __SetPlaneConstraintOrigin = 0;

		private static uint __SetPlaneConstraintNormal = 0;

		private static uint __SetPlaneConstraintFromVectors = 0;

		private static uint __SetPlaneConstraintEnabled = 0;

		private static uint __SetPlaneConstraintAxisSetting = 0;

		private static uint __PhysicsVolumeChanged = 0;

		private static uint __K2_MoveUpdatedComponent = 0;

		private static uint __IsExceedingMaxSpeed = 0;

		private static uint __GetPlaneConstraintOrigin = 0;

		private static uint __GetPlaneConstraintNormal = 0;

		private static uint __GetPlaneConstraintAxisSetting = 0;

		private static uint __GetPhysicsVolume = 0;

		private static uint __GetMaxSpeed = 0;

		private static uint __GetGravityZ = 0;

		private static uint __ConstrainNormalToPlane = 0;

		private static uint __ConstrainLocationToPlane = 0;

		private static uint __ConstrainDirectionToPlane = 0;
	}
}