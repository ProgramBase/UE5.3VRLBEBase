using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CharacterMovementComponent")]
	public partial class UCharacterMovementComponent : UPawnMovementComponent, IStaticClass, IRVOAvoidanceInterface, INetworkPredictionInterface
	{
		public ACharacter CharacterOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterOwner, __ReturnBuffer);

					return *(ACharacter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterOwner, __InBuffer);
				}
			}
		}

		public float GravityScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GravityScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GravityScale, __InBuffer);
				}
			}
		}

		public float MaxStepHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxStepHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxStepHeight, __InBuffer);
				}
			}
		}

		public float JumpZVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpZVelocity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpZVelocity, __InBuffer);
				}
			}
		}

		public float JumpOffJumpZFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpOffJumpZFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpOffJumpZFactor, __InBuffer);
				}
			}
		}

		public float WalkableFloorAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WalkableFloorAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WalkableFloorAngle, __InBuffer);
				}
			}
		}

		public float WalkableFloorZ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WalkableFloorZ, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WalkableFloorZ, __InBuffer);
				}
			}
		}

		public FVector GravityDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GravityDirection, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GravityDirection, __InBuffer);
				}
			}
		}

		public FQuat WorldToGravityTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldToGravityTransform, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldToGravityTransform, __InBuffer);
				}
			}
		}

		public FQuat GravityToWorldTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GravityToWorldTransform, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GravityToWorldTransform, __InBuffer);
				}
			}
		}

		public EMovementMode MovementMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovementMode, __ReturnBuffer);

					return *(EMovementMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovementMode, __InBuffer);
				}
			}
		}

		public byte CustomMovementMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomMovementMode, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomMovementMode, __InBuffer);
				}
			}
		}

		public ENetworkSmoothingMode NetworkSmoothingMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkSmoothingMode, __ReturnBuffer);

					return *(ENetworkSmoothingMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkSmoothingMode, __InBuffer);
				}
			}
		}

		public float GroundFriction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroundFriction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroundFriction, __InBuffer);
				}
			}
		}

		public float MaxWalkSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxWalkSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxWalkSpeed, __InBuffer);
				}
			}
		}

		public float MaxWalkSpeedCrouched
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxWalkSpeedCrouched, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxWalkSpeedCrouched, __InBuffer);
				}
			}
		}

		public float MaxSwimSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSwimSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSwimSpeed, __InBuffer);
				}
			}
		}

		public float MaxFlySpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxFlySpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxFlySpeed, __InBuffer);
				}
			}
		}

		public float MaxCustomMovementSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxCustomMovementSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxCustomMovementSpeed, __InBuffer);
				}
			}
		}

		public float MaxAcceleration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxAcceleration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxAcceleration, __InBuffer);
				}
			}
		}

		public float MinAnalogWalkSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinAnalogWalkSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinAnalogWalkSpeed, __InBuffer);
				}
			}
		}

		public float BrakingFrictionFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingFrictionFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingFrictionFactor, __InBuffer);
				}
			}
		}

		public float BrakingFriction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingFriction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingFriction, __InBuffer);
				}
			}
		}

		public float BrakingSubStepTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingSubStepTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingSubStepTime, __InBuffer);
				}
			}
		}

		public float BrakingDecelerationWalking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationWalking, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationWalking, __InBuffer);
				}
			}
		}

		public float BrakingDecelerationFalling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationFalling, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationFalling, __InBuffer);
				}
			}
		}

		public float BrakingDecelerationSwimming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationSwimming, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationSwimming, __InBuffer);
				}
			}
		}

		public float BrakingDecelerationFlying
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationFlying, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrakingDecelerationFlying, __InBuffer);
				}
			}
		}

		public float AirControl
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AirControl, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AirControl, __InBuffer);
				}
			}
		}

		public float AirControlBoostMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AirControlBoostMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AirControlBoostMultiplier, __InBuffer);
				}
			}
		}

		public float AirControlBoostVelocityThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AirControlBoostVelocityThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AirControlBoostVelocityThreshold, __InBuffer);
				}
			}
		}

		public float FallingLateralFriction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FallingLateralFriction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FallingLateralFriction, __InBuffer);
				}
			}
		}

		public float CrouchedHalfHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CrouchedHalfHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CrouchedHalfHeight, __InBuffer);
				}
			}
		}

		public float Buoyancy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Buoyancy, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Buoyancy, __InBuffer);
				}
			}
		}

		public float PerchRadiusThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerchRadiusThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerchRadiusThreshold, __InBuffer);
				}
			}
		}

		public float PerchAdditionalHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerchAdditionalHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerchAdditionalHeight, __InBuffer);
				}
			}
		}

		public FRotator RotationRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RotationRate, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RotationRate, __InBuffer);
				}
			}
		}

		public bool bUseSeparateBrakingFriction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSeparateBrakingFriction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSeparateBrakingFriction, __InBuffer);
				}
			}
		}

		public bool bApplyGravityWhileJumping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyGravityWhileJumping, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyGravityWhileJumping, __InBuffer);
				}
			}
		}

		public bool bUseControllerDesiredRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerDesiredRotation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerDesiredRotation, __InBuffer);
				}
			}
		}

		public bool bOrientRotationToMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOrientRotationToMovement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOrientRotationToMovement, __InBuffer);
				}
			}
		}

		public bool bSweepWhileNavWalking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSweepWhileNavWalking, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSweepWhileNavWalking, __InBuffer);
				}
			}
		}

		public bool bMovementInProgress
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMovementInProgress, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMovementInProgress, __InBuffer);
				}
			}
		}

		public bool bEnableScopedMovementUpdates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableScopedMovementUpdates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableScopedMovementUpdates, __InBuffer);
				}
			}
		}

		public bool bEnableServerDualMoveScopedMovementUpdates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableServerDualMoveScopedMovementUpdates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableServerDualMoveScopedMovementUpdates, __InBuffer);
				}
			}
		}

		public bool bForceMaxAccel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMaxAccel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMaxAccel, __InBuffer);
				}
			}
		}

		public bool bRunPhysicsWithNoController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRunPhysicsWithNoController, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRunPhysicsWithNoController, __InBuffer);
				}
			}
		}

		public bool bForceNextFloorCheck
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceNextFloorCheck, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceNextFloorCheck, __InBuffer);
				}
			}
		}

		public bool bShrinkProxyCapsule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShrinkProxyCapsule, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShrinkProxyCapsule, __InBuffer);
				}
			}
		}

		public bool bCanWalkOffLedges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanWalkOffLedges, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanWalkOffLedges, __InBuffer);
				}
			}
		}

		public bool bCanWalkOffLedgesWhenCrouching
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanWalkOffLedgesWhenCrouching, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanWalkOffLedgesWhenCrouching, __InBuffer);
				}
			}
		}

		public bool bNetworkSkipProxyPredictionOnNetUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkSkipProxyPredictionOnNetUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkSkipProxyPredictionOnNetUpdate, __InBuffer);
				}
			}
		}

		public bool bNetworkAlwaysReplicateTransformUpdateTimestamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkAlwaysReplicateTransformUpdateTimestamp, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkAlwaysReplicateTransformUpdateTimestamp, __InBuffer);
				}
			}
		}

		public bool bDeferUpdateMoveComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDeferUpdateMoveComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDeferUpdateMoveComponent, __InBuffer);
				}
			}
		}

		public bool bEnablePhysicsInteraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsInteraction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsInteraction, __InBuffer);
				}
			}
		}

		public bool bTouchForceScaledToMass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTouchForceScaledToMass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTouchForceScaledToMass, __InBuffer);
				}
			}
		}

		public bool bPushForceScaledToMass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPushForceScaledToMass, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPushForceScaledToMass, __InBuffer);
				}
			}
		}

		public bool bPushForceUsingZOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPushForceUsingZOffset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPushForceUsingZOffset, __InBuffer);
				}
			}
		}

		public bool bScalePushForceToVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bScalePushForceToVelocity, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bScalePushForceToVelocity, __InBuffer);
				}
			}
		}

		public USceneComponent DeferredUpdatedMoveComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeferredUpdatedMoveComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeferredUpdatedMoveComponent, __InBuffer);
				}
			}
		}

		public float MaxOutOfWaterStepHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxOutOfWaterStepHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxOutOfWaterStepHeight, __InBuffer);
				}
			}
		}

		public float OutofWaterZ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutofWaterZ, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutofWaterZ, __InBuffer);
				}
			}
		}

		public float Mass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Mass, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Mass, __InBuffer);
				}
			}
		}

		public float StandingDownwardForceScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StandingDownwardForceScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StandingDownwardForceScale, __InBuffer);
				}
			}
		}

		public float InitialPushForceFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialPushForceFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialPushForceFactor, __InBuffer);
				}
			}
		}

		public float PushForceFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PushForceFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PushForceFactor, __InBuffer);
				}
			}
		}

		public float PushForcePointZOffsetFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PushForcePointZOffsetFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PushForcePointZOffsetFactor, __InBuffer);
				}
			}
		}

		public float TouchForceFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TouchForceFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TouchForceFactor, __InBuffer);
				}
			}
		}

		public float MinTouchForce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinTouchForce, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinTouchForce, __InBuffer);
				}
			}
		}

		public float MaxTouchForce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxTouchForce, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxTouchForce, __InBuffer);
				}
			}
		}

		public float RepulsionForce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepulsionForce, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepulsionForce, __InBuffer);
				}
			}
		}

		public FVector Acceleration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Acceleration, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Acceleration, __InBuffer);
				}
			}
		}

		public FQuat LastUpdateRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateRotation, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateRotation, __InBuffer);
				}
			}
		}

		public FVector LastUpdateLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateLocation, __InBuffer);
				}
			}
		}

		public FVector LastUpdateVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateVelocity, __InBuffer);
				}
			}
		}

		public float ServerLastTransformUpdateTimeStamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerLastTransformUpdateTimeStamp, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerLastTransformUpdateTimeStamp, __InBuffer);
				}
			}
		}

		public float ServerLastClientGoodMoveAckTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerLastClientGoodMoveAckTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerLastClientGoodMoveAckTime, __InBuffer);
				}
			}
		}

		public float ServerLastClientAdjustmentTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerLastClientAdjustmentTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerLastClientAdjustmentTime, __InBuffer);
				}
			}
		}

		public FVector PendingImpulseToApply
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingImpulseToApply, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingImpulseToApply, __InBuffer);
				}
			}
		}

		public FVector PendingForceToApply
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingForceToApply, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingForceToApply, __InBuffer);
				}
			}
		}

		public float AnalogInputModifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnalogInputModifier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnalogInputModifier, __InBuffer);
				}
			}
		}

		public float MaxSimulationTimeStep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationTimeStep, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationTimeStep, __InBuffer);
				}
			}
		}

		public int MaxSimulationIterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationIterations, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationIterations, __InBuffer);
				}
			}
		}

		public int MaxJumpApexAttemptsPerSimulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxJumpApexAttemptsPerSimulation, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxJumpApexAttemptsPerSimulation, __InBuffer);
				}
			}
		}

		public float MaxDepenetrationWithGeometry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithGeometry, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithGeometry, __InBuffer);
				}
			}
		}

		public float MaxDepenetrationWithGeometryAsProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithGeometryAsProxy, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithGeometryAsProxy, __InBuffer);
				}
			}
		}

		public float MaxDepenetrationWithPawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithPawn, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithPawn, __InBuffer);
				}
			}
		}

		public float MaxDepenetrationWithPawnAsProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithPawnAsProxy, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDepenetrationWithPawnAsProxy, __InBuffer);
				}
			}
		}

		public float NetworkSimulatedSmoothLocationTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkSimulatedSmoothLocationTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkSimulatedSmoothLocationTime, __InBuffer);
				}
			}
		}

		public float NetworkSimulatedSmoothRotationTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkSimulatedSmoothRotationTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkSimulatedSmoothRotationTime, __InBuffer);
				}
			}
		}

		public float ListenServerNetworkSimulatedSmoothLocationTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ListenServerNetworkSimulatedSmoothLocationTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ListenServerNetworkSimulatedSmoothLocationTime, __InBuffer);
				}
			}
		}

		public float ListenServerNetworkSimulatedSmoothRotationTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ListenServerNetworkSimulatedSmoothRotationTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ListenServerNetworkSimulatedSmoothRotationTime, __InBuffer);
				}
			}
		}

		public float NetProxyShrinkRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetProxyShrinkRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetProxyShrinkRadius, __InBuffer);
				}
			}
		}

		public float NetProxyShrinkHalfHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetProxyShrinkHalfHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetProxyShrinkHalfHeight, __InBuffer);
				}
			}
		}

		public float NetworkMaxSmoothUpdateDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMaxSmoothUpdateDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMaxSmoothUpdateDistance, __InBuffer);
				}
			}
		}

		public float NetworkNoSmoothUpdateDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkNoSmoothUpdateDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkNoSmoothUpdateDistance, __InBuffer);
				}
			}
		}

		public float NetworkMinTimeBetweenClientAckGoodMoves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMinTimeBetweenClientAckGoodMoves, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMinTimeBetweenClientAckGoodMoves, __InBuffer);
				}
			}
		}

		public float NetworkMinTimeBetweenClientAdjustments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMinTimeBetweenClientAdjustments, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMinTimeBetweenClientAdjustments, __InBuffer);
				}
			}
		}

		public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMinTimeBetweenClientAdjustmentsLargeCorrection, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkMinTimeBetweenClientAdjustmentsLargeCorrection, __InBuffer);
				}
			}
		}

		public float NetworkLargeClientCorrectionDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkLargeClientCorrectionDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetworkLargeClientCorrectionDistance, __InBuffer);
				}
			}
		}

		public float LedgeCheckThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LedgeCheckThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LedgeCheckThreshold, __InBuffer);
				}
			}
		}

		public float JumpOutOfWaterPitch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpOutOfWaterPitch, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpOutOfWaterPitch, __InBuffer);
				}
			}
		}

		public FFindFloorResult CurrentFloor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFloor, __ReturnBuffer);

					return *(FFindFloorResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFloor, __InBuffer);
				}
			}
		}

		public EMovementMode DefaultLandMovementMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLandMovementMode, __ReturnBuffer);

					return *(EMovementMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLandMovementMode, __InBuffer);
				}
			}
		}

		public EMovementMode DefaultWaterMovementMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultWaterMovementMode, __ReturnBuffer);

					return *(EMovementMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultWaterMovementMode, __InBuffer);
				}
			}
		}

		public EMovementMode GroundMovementMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroundMovementMode, __ReturnBuffer);

					return *(EMovementMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroundMovementMode, __InBuffer);
				}
			}
		}

		public bool bMaintainHorizontalGroundVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMaintainHorizontalGroundVelocity, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMaintainHorizontalGroundVelocity, __InBuffer);
				}
			}
		}

		public bool bImpartBaseVelocityX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseVelocityX, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseVelocityX, __InBuffer);
				}
			}
		}

		public bool bImpartBaseVelocityY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseVelocityY, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseVelocityY, __InBuffer);
				}
			}
		}

		public bool bImpartBaseVelocityZ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseVelocityZ, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseVelocityZ, __InBuffer);
				}
			}
		}

		public bool bImpartBaseAngularVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseAngularVelocity, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bImpartBaseAngularVelocity, __InBuffer);
				}
			}
		}

		public bool bJustTeleported
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bJustTeleported, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bJustTeleported, __InBuffer);
				}
			}
		}

		public bool bNetworkUpdateReceived
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkUpdateReceived, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkUpdateReceived, __InBuffer);
				}
			}
		}

		public bool bNetworkMovementModeChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkMovementModeChanged, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkMovementModeChanged, __InBuffer);
				}
			}
		}

		public bool bNetworkGravityDirectionChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkGravityDirectionChanged, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetworkGravityDirectionChanged, __InBuffer);
				}
			}
		}

		public bool bIgnoreClientMovementErrorChecksAndCorrection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreClientMovementErrorChecksAndCorrection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreClientMovementErrorChecksAndCorrection, __InBuffer);
				}
			}
		}

		public bool bServerAcceptClientAuthoritativePosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bServerAcceptClientAuthoritativePosition, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bServerAcceptClientAuthoritativePosition, __InBuffer);
				}
			}
		}

		public bool bNotifyApex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyApex, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyApex, __InBuffer);
				}
			}
		}

		public bool bCheatFlying
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCheatFlying, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCheatFlying, __InBuffer);
				}
			}
		}

		public bool bWantsToCrouch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWantsToCrouch, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWantsToCrouch, __InBuffer);
				}
			}
		}

		public bool bCrouchMaintainsBaseLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCrouchMaintainsBaseLocation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCrouchMaintainsBaseLocation, __InBuffer);
				}
			}
		}

		public bool bIgnoreBaseRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreBaseRotation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreBaseRotation, __InBuffer);
				}
			}
		}

		public bool bFastAttachedMove
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFastAttachedMove, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFastAttachedMove, __InBuffer);
				}
			}
		}

		public bool bAlwaysCheckFloor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysCheckFloor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysCheckFloor, __InBuffer);
				}
			}
		}

		public bool bUseFlatBaseForFloorChecks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseFlatBaseForFloorChecks, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseFlatBaseForFloorChecks, __InBuffer);
				}
			}
		}

		public bool bPerformingJumpOff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPerformingJumpOff, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPerformingJumpOff, __InBuffer);
				}
			}
		}

		public bool bWantsToLeaveNavWalking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWantsToLeaveNavWalking, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWantsToLeaveNavWalking, __InBuffer);
				}
			}
		}

		public bool bUseRVOAvoidance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRVOAvoidance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRVOAvoidance, __InBuffer);
				}
			}
		}

		public bool bRequestedMoveUseAcceleration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRequestedMoveUseAcceleration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRequestedMoveUseAcceleration, __InBuffer);
				}
			}
		}

		public bool bWasSimulatingRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWasSimulatingRootMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWasSimulatingRootMotion, __InBuffer);
				}
			}
		}

		public bool bAllowPhysicsRotationDuringAnimRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowPhysicsRotationDuringAnimRootMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowPhysicsRotationDuringAnimRootMotion, __InBuffer);
				}
			}
		}

		public float FormerBaseVelocityDecayHalfLife
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FormerBaseVelocityDecayHalfLife, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FormerBaseVelocityDecayHalfLife, __InBuffer);
				}
			}
		}

		public bool bHasRequestedVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasRequestedVelocity, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasRequestedVelocity, __InBuffer);
				}
			}
		}

		public bool bRequestedMoveWithMaxSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRequestedMoveWithMaxSpeed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRequestedMoveWithMaxSpeed, __InBuffer);
				}
			}
		}

		public bool bWasAvoidanceUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWasAvoidanceUpdated, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWasAvoidanceUpdated, __InBuffer);
				}
			}
		}

		public bool bProjectNavMeshWalking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bProjectNavMeshWalking, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bProjectNavMeshWalking, __InBuffer);
				}
			}
		}

		public bool bProjectNavMeshOnBothWorldChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bProjectNavMeshOnBothWorldChannels, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bProjectNavMeshOnBothWorldChannels, __InBuffer);
				}
			}
		}

		public float AvoidanceConsiderationRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceConsiderationRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceConsiderationRadius, __InBuffer);
				}
			}
		}

		public FVector RequestedVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequestedVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequestedVelocity, __InBuffer);
				}
			}
		}

		public FVector LastUpdateRequestedVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateRequestedVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUpdateRequestedVelocity, __InBuffer);
				}
			}
		}

		public int AvoidanceUID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceUID, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceUID, __InBuffer);
				}
			}
		}

		public FNavAvoidanceMask AvoidanceGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceGroup, __ReturnBuffer);

					return *(FNavAvoidanceMask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceGroup, __InBuffer);
				}
			}
		}

		public FNavAvoidanceMask GroupsToAvoid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroupsToAvoid, __ReturnBuffer);

					return *(FNavAvoidanceMask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroupsToAvoid, __InBuffer);
				}
			}
		}

		public FNavAvoidanceMask GroupsToIgnore
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroupsToIgnore, __ReturnBuffer);

					return *(FNavAvoidanceMask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroupsToIgnore, __InBuffer);
				}
			}
		}

		public float AvoidanceWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AvoidanceWeight, __InBuffer);
				}
			}
		}

		public FVector PendingLaunchVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingLaunchVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingLaunchVelocity, __InBuffer);
				}
			}
		}

		public float NavMeshProjectionInterval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionInterval, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionInterval, __InBuffer);
				}
			}
		}

		public float NavMeshProjectionTimer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionTimer, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionTimer, __InBuffer);
				}
			}
		}

		public float NavMeshProjectionInterpSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionInterpSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionInterpSpeed, __InBuffer);
				}
			}
		}

		public float NavMeshProjectionHeightScaleUp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionHeightScaleUp, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionHeightScaleUp, __InBuffer);
				}
			}
		}

		public float NavMeshProjectionHeightScaleDown
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionHeightScaleDown, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavMeshProjectionHeightScaleDown, __InBuffer);
				}
			}
		}

		public float NavWalkingFloorDistTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavWalkingFloorDistTolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavWalkingFloorDistTolerance, __InBuffer);
				}
			}
		}

		public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostPhysicsTickFunction, __ReturnBuffer);

					return *(FCharacterMovementComponentPostPhysicsTickFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostPhysicsTickFunction, __InBuffer);
				}
			}
		}

		public float MinTimeBetweenTimeStampResets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinTimeBetweenTimeStampResets, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinTimeBetweenTimeStampResets, __InBuffer);
				}
			}
		}

		public FRootMotionSourceGroup CurrentRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentRootMotion, __ReturnBuffer);

					return *(FRootMotionSourceGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentRootMotion, __InBuffer);
				}
			}
		}

		public FRootMotionSourceGroup ServerCorrectionRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerCorrectionRootMotion, __ReturnBuffer);

					return *(FRootMotionSourceGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerCorrectionRootMotion, __InBuffer);
				}
			}
		}

		public FRootMotionMovementParams RootMotionParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionParams, __ReturnBuffer);

					return *(FRootMotionMovementParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionParams, __InBuffer);
				}
			}
		}

		public FVector AnimRootMotionVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimRootMotionVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimRootMotionVelocity, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CharacterMovementComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetWalkableFloorZ(float InWalkableFloorZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InWalkableFloorZ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWalkableFloorZ, __InBuffer);
			}
		}

		public virtual void SetWalkableFloorAngle(float InWalkableFloorAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InWalkableFloorAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWalkableFloorAngle, __InBuffer);
			}
		}

		/// <param name="NewMovementMode">
		/// The new movement mode
		/// </param>
		/// <param name="NewCustomMode">
		/// The new custom sub-mode, only applicable if NewMovementMode is Custom.
		/// </param>
		public virtual void SetMovementMode(EMovementMode NewMovementMode, byte NewCustomMode = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)NewMovementMode;

				*(byte*)(__InBuffer + 1) = NewCustomMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMovementMode, __InBuffer);
			}
		}

		public virtual void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GroupMask?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGroupsToIgnoreMask, __InBuffer);
			}
		}

		public virtual void SetGroupsToIgnore(int GroupFlags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = GroupFlags;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGroupsToIgnore, __InBuffer);
			}
		}

		public virtual void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GroupMask?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGroupsToAvoidMask, __InBuffer);
			}
		}

		public virtual void SetGroupsToAvoid(int GroupFlags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = GroupFlags;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGroupsToAvoid, __InBuffer);
			}
		}

		public virtual void SetCrouchedHalfHeight(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCrouchedHalfHeight, __InBuffer);
			}
		}

		public virtual void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GroupMask?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAvoidanceGroupMask, __InBuffer);
			}
		}

		public virtual void SetAvoidanceGroup(int GroupFlags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = GroupFlags;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAvoidanceGroup, __InBuffer);
			}
		}

		public virtual void SetAvoidanceEnabled(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAvoidanceEnabled, __InBuffer);
			}
		}

		public virtual float K2_GetWalkableFloorZ()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __K2_GetWalkableFloorZ, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float K2_GetWalkableFloorAngle()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __K2_GetWalkableFloorAngle, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="CapsuleLocation">
		/// Location where the capsule sweep should originate
		/// </param>
		/// <param name="FloorResult">
		/// Result of the floor check
		/// </param>
		public virtual void K2_FindFloor(FVector CapsuleLocation, ref FFindFloorResult FloorResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = CapsuleLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FloorResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_FindFloor, __InBuffer, __OutBuffer);

				FloorResult = *(FFindFloorResult*)(__OutBuffer);

			}
		}

		/// <param name="CapsuleLocation">
		/// Location where the capsule sweep should originate
		/// </param>
		/// <param name="LineDistance">
		/// If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal.
		/// </param>
		/// <param name="SweepDistance">
		/// If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance.
		/// </param>
		/// <param name="SweepRadius">
		/// The radius to use for sweep tests. Should be <= capsule radius.
		/// </param>
		/// <param name="FloorResult">
		/// Result of the floor check
		/// </param>
		public virtual void K2_ComputeFloorDist(FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, ref FFindFloorResult FloorResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = CapsuleLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = LineDistance;

				*(float*)(__InBuffer + 12) = SweepDistance;

				*(float*)(__InBuffer + 16) = SweepRadius;

				*(nint*)(__InBuffer + 20) = FloorResult?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_ComputeFloorDist, __InBuffer, __OutBuffer);

				FloorResult = *(FFindFloorResult*)(__OutBuffer);

			}
		}

		public virtual bool IsWalking()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsWalking, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsWalkable(FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsWalkable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetValidPerchRadius()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValidPerchRadius, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPerchRadiusThreshold()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPerchRadiusThreshold, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UPrimitiveComponent GetMovementBase()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMovementBase, __ReturnBuffer);

				return *(UPrimitiveComponent*)__ReturnBuffer;
			}
		}

		public virtual float GetMinAnalogSpeed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMinAnalogSpeed, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMaxJumpHeightWithJumpTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxJumpHeightWithJumpTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMaxJumpHeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxJumpHeight, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMaxBrakingDeceleration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxBrakingDeceleration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMaxAcceleration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxAcceleration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLastUpdateVelocity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastUpdateVelocity, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetLastUpdateRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastUpdateRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLastUpdateRequestedVelocity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastUpdateRequestedVelocity, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetLastUpdateLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastUpdateLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetImpartedMovementBaseVelocity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetImpartedMovementBaseVelocity, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FVector GetCurrentAcceleration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentAcceleration, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual float GetCrouchedHalfHeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCrouchedHalfHeight, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual ACharacter GetCharacterOwner()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCharacterOwner, __ReturnBuffer);

				return *(ACharacter*)__ReturnBuffer;
			}
		}

		public virtual float GetAnalogInputModifier()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnalogInputModifier, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void DisableMovement()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DisableMovement);
			}
		}

		public virtual void ClearAccumulatedForces()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAccumulatedForces);
			}
		}

		public virtual void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = OverlappedComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Other?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherComp?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = OtherBodyIndex;

				*(bool*)(__InBuffer + 28) = bFromSweep;

				*(nint*)(__InBuffer + 29) = SweepResult?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CapsuleTouched, __InBuffer);
			}
		}

		/// <param name="DeltaTime">
		/// time elapsed since last frame.
		/// </param>
		/// <param name="Friction">
		/// coefficient of friction when not accelerating, or in the direction opposite acceleration.
		/// </param>
		/// <param name="bFluid">
		/// true if moving through a fluid, causing Friction to always be applied regardless of acceleration.
		/// </param>
		/// <param name="BrakingDeceleration">
		/// deceleration applied when not accelerating, or when exceeding max velocity.
		/// </param>
		public virtual void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = DeltaTime;

				*(float*)(__InBuffer + 4) = Friction;

				*(bool*)(__InBuffer + 8) = bFluid;

				*(float*)(__InBuffer + 9) = BrakingDeceleration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CalcVelocity, __InBuffer);
			}
		}

		/// <param name="Impulse">
		/// Impulse to apply.
		/// </param>
		/// <param name="bVelocityChange">
		/// Whether or not the impulse is relative to mass.
		/// </param>
		public virtual void AddImpulse(FVector Impulse, bool bVelocityChange = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bVelocityChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddImpulse, __InBuffer);
			}
		}

		/// <param name="Force">
		/// Force to apply.
		/// </param>
		public virtual void AddForce(FVector Force)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Force?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddForce, __InBuffer);
			}
		}

		private static uint __CharacterOwner = 0;

		private static uint __GravityScale = 0;

		private static uint __MaxStepHeight = 0;

		private static uint __JumpZVelocity = 0;

		private static uint __JumpOffJumpZFactor = 0;

		private static uint __WalkableFloorAngle = 0;

		private static uint __WalkableFloorZ = 0;

		private static uint __GravityDirection = 0;

		private static uint __WorldToGravityTransform = 0;

		private static uint __GravityToWorldTransform = 0;

		private static uint __MovementMode = 0;

		private static uint __CustomMovementMode = 0;

		private static uint __NetworkSmoothingMode = 0;

		private static uint __GroundFriction = 0;

		private static uint __MaxWalkSpeed = 0;

		private static uint __MaxWalkSpeedCrouched = 0;

		private static uint __MaxSwimSpeed = 0;

		private static uint __MaxFlySpeed = 0;

		private static uint __MaxCustomMovementSpeed = 0;

		private static uint __MaxAcceleration = 0;

		private static uint __MinAnalogWalkSpeed = 0;

		private static uint __BrakingFrictionFactor = 0;

		private static uint __BrakingFriction = 0;

		private static uint __BrakingSubStepTime = 0;

		private static uint __BrakingDecelerationWalking = 0;

		private static uint __BrakingDecelerationFalling = 0;

		private static uint __BrakingDecelerationSwimming = 0;

		private static uint __BrakingDecelerationFlying = 0;

		private static uint __AirControl = 0;

		private static uint __AirControlBoostMultiplier = 0;

		private static uint __AirControlBoostVelocityThreshold = 0;

		private static uint __FallingLateralFriction = 0;

		private static uint __CrouchedHalfHeight = 0;

		private static uint __Buoyancy = 0;

		private static uint __PerchRadiusThreshold = 0;

		private static uint __PerchAdditionalHeight = 0;

		private static uint __RotationRate = 0;

		private static uint __bUseSeparateBrakingFriction = 0;

		private static uint __bApplyGravityWhileJumping = 0;

		private static uint __bUseControllerDesiredRotation = 0;

		private static uint __bOrientRotationToMovement = 0;

		private static uint __bSweepWhileNavWalking = 0;

		private static uint __bMovementInProgress = 0;

		private static uint __bEnableScopedMovementUpdates = 0;

		private static uint __bEnableServerDualMoveScopedMovementUpdates = 0;

		private static uint __bForceMaxAccel = 0;

		private static uint __bRunPhysicsWithNoController = 0;

		private static uint __bForceNextFloorCheck = 0;

		private static uint __bShrinkProxyCapsule = 0;

		private static uint __bCanWalkOffLedges = 0;

		private static uint __bCanWalkOffLedgesWhenCrouching = 0;

		private static uint __bNetworkSkipProxyPredictionOnNetUpdate = 0;

		private static uint __bNetworkAlwaysReplicateTransformUpdateTimestamp = 0;

		private static uint __bDeferUpdateMoveComponent = 0;

		private static uint __bEnablePhysicsInteraction = 0;

		private static uint __bTouchForceScaledToMass = 0;

		private static uint __bPushForceScaledToMass = 0;

		private static uint __bPushForceUsingZOffset = 0;

		private static uint __bScalePushForceToVelocity = 0;

		private static uint __DeferredUpdatedMoveComponent = 0;

		private static uint __MaxOutOfWaterStepHeight = 0;

		private static uint __OutofWaterZ = 0;

		private static uint __Mass = 0;

		private static uint __StandingDownwardForceScale = 0;

		private static uint __InitialPushForceFactor = 0;

		private static uint __PushForceFactor = 0;

		private static uint __PushForcePointZOffsetFactor = 0;

		private static uint __TouchForceFactor = 0;

		private static uint __MinTouchForce = 0;

		private static uint __MaxTouchForce = 0;

		private static uint __RepulsionForce = 0;

		private static uint __Acceleration = 0;

		private static uint __LastUpdateRotation = 0;

		private static uint __LastUpdateLocation = 0;

		private static uint __LastUpdateVelocity = 0;

		private static uint __ServerLastTransformUpdateTimeStamp = 0;

		private static uint __ServerLastClientGoodMoveAckTime = 0;

		private static uint __ServerLastClientAdjustmentTime = 0;

		private static uint __PendingImpulseToApply = 0;

		private static uint __PendingForceToApply = 0;

		private static uint __AnalogInputModifier = 0;

		private static uint __MaxSimulationTimeStep = 0;

		private static uint __MaxSimulationIterations = 0;

		private static uint __MaxJumpApexAttemptsPerSimulation = 0;

		private static uint __MaxDepenetrationWithGeometry = 0;

		private static uint __MaxDepenetrationWithGeometryAsProxy = 0;

		private static uint __MaxDepenetrationWithPawn = 0;

		private static uint __MaxDepenetrationWithPawnAsProxy = 0;

		private static uint __NetworkSimulatedSmoothLocationTime = 0;

		private static uint __NetworkSimulatedSmoothRotationTime = 0;

		private static uint __ListenServerNetworkSimulatedSmoothLocationTime = 0;

		private static uint __ListenServerNetworkSimulatedSmoothRotationTime = 0;

		private static uint __NetProxyShrinkRadius = 0;

		private static uint __NetProxyShrinkHalfHeight = 0;

		private static uint __NetworkMaxSmoothUpdateDistance = 0;

		private static uint __NetworkNoSmoothUpdateDistance = 0;

		private static uint __NetworkMinTimeBetweenClientAckGoodMoves = 0;

		private static uint __NetworkMinTimeBetweenClientAdjustments = 0;

		private static uint __NetworkMinTimeBetweenClientAdjustmentsLargeCorrection = 0;

		private static uint __NetworkLargeClientCorrectionDistance = 0;

		private static uint __LedgeCheckThreshold = 0;

		private static uint __JumpOutOfWaterPitch = 0;

		private static uint __CurrentFloor = 0;

		private static uint __DefaultLandMovementMode = 0;

		private static uint __DefaultWaterMovementMode = 0;

		private static uint __GroundMovementMode = 0;

		private static uint __bMaintainHorizontalGroundVelocity = 0;

		private static uint __bImpartBaseVelocityX = 0;

		private static uint __bImpartBaseVelocityY = 0;

		private static uint __bImpartBaseVelocityZ = 0;

		private static uint __bImpartBaseAngularVelocity = 0;

		private static uint __bJustTeleported = 0;

		private static uint __bNetworkUpdateReceived = 0;

		private static uint __bNetworkMovementModeChanged = 0;

		private static uint __bNetworkGravityDirectionChanged = 0;

		private static uint __bIgnoreClientMovementErrorChecksAndCorrection = 0;

		private static uint __bServerAcceptClientAuthoritativePosition = 0;

		private static uint __bNotifyApex = 0;

		private static uint __bCheatFlying = 0;

		private static uint __bWantsToCrouch = 0;

		private static uint __bCrouchMaintainsBaseLocation = 0;

		private static uint __bIgnoreBaseRotation = 0;

		private static uint __bFastAttachedMove = 0;

		private static uint __bAlwaysCheckFloor = 0;

		private static uint __bUseFlatBaseForFloorChecks = 0;

		private static uint __bPerformingJumpOff = 0;

		private static uint __bWantsToLeaveNavWalking = 0;

		private static uint __bUseRVOAvoidance = 0;

		private static uint __bRequestedMoveUseAcceleration = 0;

		private static uint __bWasSimulatingRootMotion = 0;

		private static uint __bAllowPhysicsRotationDuringAnimRootMotion = 0;

		private static uint __FormerBaseVelocityDecayHalfLife = 0;

		private static uint __bHasRequestedVelocity = 0;

		private static uint __bRequestedMoveWithMaxSpeed = 0;

		private static uint __bWasAvoidanceUpdated = 0;

		private static uint __bProjectNavMeshWalking = 0;

		private static uint __bProjectNavMeshOnBothWorldChannels = 0;

		private static uint __AvoidanceConsiderationRadius = 0;

		private static uint __RequestedVelocity = 0;

		private static uint __LastUpdateRequestedVelocity = 0;

		private static uint __AvoidanceUID = 0;

		private static uint __AvoidanceGroup = 0;

		private static uint __GroupsToAvoid = 0;

		private static uint __GroupsToIgnore = 0;

		private static uint __AvoidanceWeight = 0;

		private static uint __PendingLaunchVelocity = 0;

		private static uint __NavMeshProjectionInterval = 0;

		private static uint __NavMeshProjectionTimer = 0;

		private static uint __NavMeshProjectionInterpSpeed = 0;

		private static uint __NavMeshProjectionHeightScaleUp = 0;

		private static uint __NavMeshProjectionHeightScaleDown = 0;

		private static uint __NavWalkingFloorDistTolerance = 0;

		private static uint __PostPhysicsTickFunction = 0;

		private static uint __MinTimeBetweenTimeStampResets = 0;

		private static uint __CurrentRootMotion = 0;

		private static uint __ServerCorrectionRootMotion = 0;

		private static uint __RootMotionParams = 0;

		private static uint __AnimRootMotionVelocity = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetWalkableFloorZ = 0;

		private static uint __SetWalkableFloorAngle = 0;

		private static uint __SetMovementMode = 0;

		private static uint __SetGroupsToIgnoreMask = 0;

		private static uint __SetGroupsToIgnore = 0;

		private static uint __SetGroupsToAvoidMask = 0;

		private static uint __SetGroupsToAvoid = 0;

		private static uint __SetCrouchedHalfHeight = 0;

		private static uint __SetAvoidanceGroupMask = 0;

		private static uint __SetAvoidanceGroup = 0;

		private static uint __SetAvoidanceEnabled = 0;

		private static uint __K2_GetWalkableFloorZ = 0;

		private static uint __K2_GetWalkableFloorAngle = 0;

		private static uint __K2_FindFloor = 0;

		private static uint __K2_ComputeFloorDist = 0;

		private static uint __IsWalking = 0;

		private static uint __IsWalkable = 0;

		private static uint __GetValidPerchRadius = 0;

		private static uint __GetPerchRadiusThreshold = 0;

		private static uint __GetMovementBase = 0;

		private static uint __GetMinAnalogSpeed = 0;

		private static uint __GetMaxJumpHeightWithJumpTime = 0;

		private static uint __GetMaxJumpHeight = 0;

		private static uint __GetMaxBrakingDeceleration = 0;

		private static uint __GetMaxAcceleration = 0;

		private static uint __GetLastUpdateVelocity = 0;

		private static uint __GetLastUpdateRotation = 0;

		private static uint __GetLastUpdateRequestedVelocity = 0;

		private static uint __GetLastUpdateLocation = 0;

		private static uint __GetImpartedMovementBaseVelocity = 0;

		private static uint __GetCurrentAcceleration = 0;

		private static uint __GetCrouchedHalfHeight = 0;

		private static uint __GetCharacterOwner = 0;

		private static uint __GetAnalogInputModifier = 0;

		private static uint __DisableMovement = 0;

		private static uint __ClearAccumulatedForces = 0;

		private static uint __CapsuleTouched = 0;

		private static uint __CalcVelocity = 0;

		private static uint __AddImpulse = 0;

		private static uint __AddForce = 0;
	}
}