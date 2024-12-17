using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Character")]
	public partial class ACharacter : APawn, IStaticClass
	{
		public USkeletalMeshComponent Mesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Mesh, __ReturnBuffer);

					return *(USkeletalMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Mesh, __InBuffer);
				}
			}
		}

		public UCharacterMovementComponent CharacterMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterMovement, __ReturnBuffer);

					return *(UCharacterMovementComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterMovement, __InBuffer);
				}
			}
		}

		public UCapsuleComponent CapsuleComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleComponent, __ReturnBuffer);

					return *(UCapsuleComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleComponent, __InBuffer);
				}
			}
		}

		public UArrowComponent ArrowComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowComponent, __ReturnBuffer);

					return *(UArrowComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowComponent, __InBuffer);
				}
			}
		}

		public FBasedMovementInfo BasedMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BasedMovement, __ReturnBuffer);

					return *(FBasedMovementInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BasedMovement, __InBuffer);
				}
			}
		}

		public FBasedMovementInfo ReplicatedBasedMovement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedBasedMovement, __ReturnBuffer);

					return *(FBasedMovementInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedBasedMovement, __InBuffer);
				}
			}
		}

		public float AnimRootMotionTranslationScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimRootMotionTranslationScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimRootMotionTranslationScale, __InBuffer);
				}
			}
		}

		public FVector BaseTranslationOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseTranslationOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseTranslationOffset, __InBuffer);
				}
			}
		}

		public FQuat BaseRotationOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseRotationOffset, __ReturnBuffer);

					return *(FQuat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseRotationOffset, __InBuffer);
				}
			}
		}

		public float ReplicatedServerLastTransformUpdateTimeStamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedServerLastTransformUpdateTimeStamp, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedServerLastTransformUpdateTimeStamp, __InBuffer);
				}
			}
		}

		public float ReplayLastTransformUpdateTimeStamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplayLastTransformUpdateTimeStamp, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplayLastTransformUpdateTimeStamp, __InBuffer);
				}
			}
		}

		public byte ReplicatedMovementMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedMovementMode, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedMovementMode, __InBuffer);
				}
			}
		}

		public FVector_NetQuantizeNormal ReplicatedGravityDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedGravityDirection, __ReturnBuffer);

					return *(FVector_NetQuantizeNormal*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedGravityDirection, __InBuffer);
				}
			}
		}

		public bool bInBaseReplication
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInBaseReplication, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInBaseReplication, __InBuffer);
				}
			}
		}

		public float CrouchedEyeHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CrouchedEyeHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CrouchedEyeHeight, __InBuffer);
				}
			}
		}

		public bool bIsCrouched
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCrouched, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsCrouched, __InBuffer);
				}
			}
		}

		public bool bProxyIsJumpForceApplied
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bProxyIsJumpForceApplied, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bProxyIsJumpForceApplied, __InBuffer);
				}
			}
		}

		public bool bPressedJump
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPressedJump, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPressedJump, __InBuffer);
				}
			}
		}

		public bool bClientUpdating
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClientUpdating, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClientUpdating, __InBuffer);
				}
			}
		}

		public bool bClientWasFalling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClientWasFalling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClientWasFalling, __InBuffer);
				}
			}
		}

		public bool bClientResimulateRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClientResimulateRootMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClientResimulateRootMotion, __InBuffer);
				}
			}
		}

		public bool bClientResimulateRootMotionSources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClientResimulateRootMotionSources, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClientResimulateRootMotionSources, __InBuffer);
				}
			}
		}

		public bool bSimGravityDisabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSimGravityDisabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSimGravityDisabled, __InBuffer);
				}
			}
		}

		public bool bClientCheckEncroachmentOnNetUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClientCheckEncroachmentOnNetUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClientCheckEncroachmentOnNetUpdate, __InBuffer);
				}
			}
		}

		public bool bServerMoveIgnoreRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bServerMoveIgnoreRootMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bServerMoveIgnoreRootMotion, __InBuffer);
				}
			}
		}

		public bool bWasJumping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWasJumping, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWasJumping, __InBuffer);
				}
			}
		}

		public float JumpKeyHoldTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpKeyHoldTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpKeyHoldTime, __InBuffer);
				}
			}
		}

		public float JumpForceTimeRemaining
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpForceTimeRemaining, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpForceTimeRemaining, __InBuffer);
				}
			}
		}

		public float ProxyJumpForceStartedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProxyJumpForceStartedTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProxyJumpForceStartedTime, __InBuffer);
				}
			}
		}

		public float JumpMaxHoldTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpMaxHoldTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpMaxHoldTime, __InBuffer);
				}
			}
		}

		public int JumpMaxCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpMaxCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpMaxCount, __InBuffer);
				}
			}
		}

		public int JumpCurrentCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpCurrentCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpCurrentCount, __InBuffer);
				}
			}
		}

		public int JumpCurrentCountPreJump
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __JumpCurrentCountPreJump, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __JumpCurrentCountPreJump, __InBuffer);
				}
			}
		}

		public FCharacterReachedApexSignature OnReachedJumpApex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnReachedJumpApex, __ReturnBuffer);

					return *(FCharacterReachedApexSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnReachedJumpApex, __InBuffer);
				}
			}
		}

		public FLandedSignature LandedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandedDelegate, __ReturnBuffer);

					return *(FLandedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandedDelegate, __InBuffer);
				}
			}
		}

		public FMovementModeChangedSignature MovementModeChangedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovementModeChangedDelegate, __ReturnBuffer);

					return *(FMovementModeChangedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovementModeChangedDelegate, __InBuffer);
				}
			}
		}

		public FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnCharacterMovementUpdated, __ReturnBuffer);

					return *(FCharacterMovementUpdatedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnCharacterMovementUpdated, __InBuffer);
				}
			}
		}

		public FRootMotionSourceGroup SavedRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SavedRootMotion, __ReturnBuffer);

					return *(FRootMotionSourceGroup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SavedRootMotion, __InBuffer);
				}
			}
		}

		public FRootMotionMovementParams ClientRootMotionParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClientRootMotionParams, __ReturnBuffer);

					return *(FRootMotionMovementParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClientRootMotionParams, __InBuffer);
				}
			}
		}

		public TArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionRepMoves, __ReturnBuffer);

					return *(TArray<FSimulatedRootMotionReplicatedMove>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionRepMoves, __InBuffer);
				}
			}
		}

		public FRepRootMotionMontage RepRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepRootMotion, __ReturnBuffer);

					return *(FRepRootMotionMontage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepRootMotion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Character");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <see>
		/// OnEndCrouch
		/// </see>
		/// <see>
		/// IsCrouched
		/// </see>
		/// <see>
		/// CharacterMovement->WantsToCrouch
		/// </see>
		public virtual void UnCrouch(bool bClientSimulation = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bClientSimulation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnCrouch, __InBuffer);
			}
		}

		public virtual void StopJumping()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopJumping);
			}
		}

		public virtual void StopAnimMontage(UAnimMontage AnimMontage = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimMontage?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAnimMontage, __InBuffer);
			}
		}

		public virtual void ServerMovePacked(FCharacterServerMovePackedBits PackedBits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PackedBits?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMovePacked, __InBuffer);
			}
		}

		public virtual void ServerMoveOld(float OldTimeStamp, FVector_NetQuantize10 OldAccel, byte OldMoveFlags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = OldTimeStamp;

				*(nint*)(__InBuffer + 4) = OldAccel?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = OldMoveFlags;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMoveOld, __InBuffer);
			}
		}

		public virtual void ServerMoveNoBase(float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, byte ClientMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[27];

				*(float*)(__InBuffer) = TimeStamp;

				*(nint*)(__InBuffer + 4) = InAccel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = ClientLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 20) = CompressedMoveFlags;

				*(byte*)(__InBuffer + 21) = ClientRoll;

				*(uint*)(__InBuffer + 22) = View;

				*(byte*)(__InBuffer + 26) = ClientMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMoveNoBase, __InBuffer);
			}
		}

		public virtual void ServerMoveDualNoBase(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, byte ClientMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(float*)(__InBuffer) = TimeStamp0;

				*(nint*)(__InBuffer + 4) = InAccel0?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = PendingFlags;

				*(uint*)(__InBuffer + 13) = View0;

				*(float*)(__InBuffer + 17) = TimeStamp;

				*(nint*)(__InBuffer + 21) = InAccel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 29) = ClientLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 37) = NewFlags;

				*(byte*)(__InBuffer + 38) = ClientRoll;

				*(uint*)(__InBuffer + 39) = View;

				*(byte*)(__InBuffer + 43) = ClientMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMoveDualNoBase, __InBuffer);
			}
		}

		public virtual void ServerMoveDualHybridRootMotion(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[60];

				*(float*)(__InBuffer) = TimeStamp0;

				*(nint*)(__InBuffer + 4) = InAccel0?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = PendingFlags;

				*(uint*)(__InBuffer + 13) = View0;

				*(float*)(__InBuffer + 17) = TimeStamp;

				*(nint*)(__InBuffer + 21) = InAccel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 29) = ClientLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 37) = NewFlags;

				*(byte*)(__InBuffer + 38) = ClientRoll;

				*(uint*)(__InBuffer + 39) = View;

				*(nint*)(__InBuffer + 43) = ClientMovementBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 51) = ClientBaseBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 59) = ClientMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMoveDualHybridRootMotion, __InBuffer);
			}
		}

		public virtual void ServerMoveDual(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[60];

				*(float*)(__InBuffer) = TimeStamp0;

				*(nint*)(__InBuffer + 4) = InAccel0?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 12) = PendingFlags;

				*(uint*)(__InBuffer + 13) = View0;

				*(float*)(__InBuffer + 17) = TimeStamp;

				*(nint*)(__InBuffer + 21) = InAccel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 29) = ClientLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 37) = NewFlags;

				*(byte*)(__InBuffer + 38) = ClientRoll;

				*(uint*)(__InBuffer + 39) = View;

				*(nint*)(__InBuffer + 43) = ClientMovementBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 51) = ClientBaseBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 59) = ClientMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMoveDual, __InBuffer);
			}
		}

		public virtual void ServerMove(float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[43];

				*(float*)(__InBuffer) = TimeStamp;

				*(nint*)(__InBuffer + 4) = InAccel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = ClientLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 20) = CompressedMoveFlags;

				*(byte*)(__InBuffer + 21) = ClientRoll;

				*(uint*)(__InBuffer + 22) = View;

				*(nint*)(__InBuffer + 26) = ClientMovementBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 34) = ClientBaseBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 42) = ClientMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerMove, __InBuffer);
			}
		}

		public virtual void RootMotionDebugClientPrintOnScreen(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __RootMotionDebugClientPrintOnScreen, __InBuffer);
			}
		}

		public virtual float PlayAnimMontage(UAnimMontage AnimMontage, float InPlayRate = 1.000000f, FName StartSectionName = null)
		{
			unsafe
			{
				StartSectionName ??= new FName("None");

				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = AnimMontage?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InPlayRate;

				*(nint*)(__InBuffer + 12) = StartSectionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PlayAnimMontage, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Z velocity is zero during walking movement, and will be here as well. Another velocity can be computed here if desired and will be used when starting to fall.
		/// </note>
		/// <param name="PreviousFloorImpactNormal">
		/// Normal of the previous walkable floor.
		/// </param>
		/// <param name="PreviousFloorContactNormal">
		/// Normal of the contact with the previous walkable floor.
		/// </param>
		/// <param name="PreviousLocation">
		/// Previous character location before movement off the ledge.
		/// </param>
		/// <param name="TimeTick">
		/// Time delta of movement update resulting in moving off the ledge.
		/// </param>
		public virtual void OnWalkingOffLedge(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = PreviousFloorImpactNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousFloorContactNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PreviousLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = TimeDelta;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnWalkingOffLedge, __InBuffer);
			}
		}

		public virtual void OnRep_RootMotion()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_RootMotion);
			}
		}

		public virtual void OnRep_ReplicatedBasedMovement()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicatedBasedMovement);
			}
		}

		public virtual void OnRep_ReplayLastTransformUpdateTimeStamp()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplayLastTransformUpdateTimeStamp);
			}
		}

		public virtual void OnRep_IsCrouched()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_IsCrouched);
			}
		}

		public virtual void OnLaunched(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = LaunchVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bXYOverride;

				*(bool*)(__InBuffer + 9) = bZOverride;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnLaunched, __InBuffer);
			}
		}

		/// <param name="Hit">
		/// Result describing the landing that resulted in a valid landing spot.
		/// </param>
		/// <see>
		/// OnMovementModeChanged()
		/// </see>
		public virtual void OnLanded(FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnLanded, __InBuffer);
			}
		}

		public virtual void OnJumped()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnJumped);
			}
		}

		/// <param name="LaunchVelocity">
		/// is the velocity to impart to the Character
		/// </param>
		/// <param name="bXYOverride">
		/// if true replace the XY part of the Character's velocity instead of adding to it.
		/// </param>
		/// <param name="bZOverride">
		/// if true replace the Z component of the Character's velocity instead of adding to it.
		/// </param>
		public virtual void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = LaunchVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bXYOverride;

				*(bool*)(__InBuffer + 9) = bZOverride;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LaunchCharacter, __InBuffer);
			}
		}

		/// <note>
		/// C++ code should override UCharacterMovementComponent::PhysCustom() instead.
		/// </note>
		/// <see>
		/// UCharacterMovementComponent::PhysCustom()
		/// </see>
		public virtual void K2_UpdateCustomMovement(float DeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTime;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_UpdateCustomMovement, __InBuffer);
			}
		}

		/// <param name="HalfHeightAdjust">
		/// difference between default collision half-height, and actual crouched capsule half-height.
		/// </param>
		/// <param name="ScaledHalfHeightAdjust">
		/// difference after component scale is taken in to account.
		/// </param>
		public virtual void K2_OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = HalfHeightAdjust;

				*(float*)(__InBuffer + 4) = ScaledHalfHeightAdjust;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnStartCrouch, __InBuffer);
			}
		}

		/// <param name="PrevMovementMode">
		/// Movement mode before the change
		/// </param>
		/// <param name="NewMovementMode">
		/// New movement mode
		/// </param>
		/// <param name="PrevCustomMode">
		/// Custom mode before the change (applicable if PrevMovementMode is Custom)
		/// </param>
		/// <param name="NewCustomMode">
		/// New custom mode (applicable if NewMovementMode is Custom)
		/// </param>
		public virtual void K2_OnMovementModeChanged(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(byte*)(__InBuffer) = (byte)PrevMovementMode;

				*(byte*)(__InBuffer + 1) = (byte)NewMovementMode;

				*(byte*)(__InBuffer + 2) = PrevCustomMode;

				*(byte*)(__InBuffer + 3) = NewCustomMode;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnMovementModeChanged, __InBuffer);
			}
		}

		/// <param name="HalfHeightAdjust">
		/// difference between default collision half-height, and actual crouched capsule half-height.
		/// </param>
		/// <param name="ScaledHalfHeightAdjust">
		/// difference after component scale is taken in to account.
		/// </param>
		public virtual void K2_OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = HalfHeightAdjust;

				*(float*)(__InBuffer + 4) = ScaledHalfHeightAdjust;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnEndCrouch, __InBuffer);
			}
		}

		public virtual void Jump()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Jump);
			}
		}

		public virtual bool IsPlayingRootMotion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlayingRootMotion, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPlayingNetworkedRootMotionMontage()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlayingNetworkedRootMotionMontage, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// CharacterMovement->IsFalling
		/// </see>
		public virtual bool IsJumpProvidingForce()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsJumpProvidingForce, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasAnyRootMotion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasAnyRootMotion, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UAnimMontage GetCurrentMontage()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentMontage, __ReturnBuffer);

				return *(UAnimMontage*)__ReturnBuffer;
			}
		}

		public virtual FVector GetBaseTranslationOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBaseTranslationOffset, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetBaseRotationOffsetRotator()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBaseRotationOffsetRotator, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual float GetAnimRootMotionTranslationScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnimRootMotionTranslationScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// OnStartCrouch
		/// </see>
		/// <see>
		/// IsCrouched
		/// </see>
		/// <see>
		/// CharacterMovement->WantsToCrouch
		/// </see>
		public virtual void Crouch(bool bClientSimulation = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bClientSimulation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Crouch, __InBuffer);
			}
		}

		public virtual void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[31];

				*(float*)(__InBuffer) = TimeStamp;

				*(nint*)(__InBuffer + 4) = NewLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = NewBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = NewBaseBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bHasBase;

				*(bool*)(__InBuffer + 29) = bBaseRelativePosition;

				*(byte*)(__InBuffer + 30) = ServerMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientVeryShortAdjustPosition, __InBuffer);
			}
		}

		public virtual void ClientMoveResponsePacked(FCharacterMoveResponsePackedBits PackedBits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PackedBits?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientMoveResponsePacked, __InBuffer);
			}
		}

		public virtual void ClientCheatWalk()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientCheatWalk);
			}
		}

		public virtual void ClientCheatGhost()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientCheatGhost);
			}
		}

		public virtual void ClientCheatFly()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientCheatFly);
			}
		}

		public virtual void ClientAdjustRootMotionSourcePosition(float TimeStamp, FRootMotionSourceGroup ServerRootMotion, bool bHasAnimRootMotion, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, UPrimitiveComponent ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(float*)(__InBuffer) = TimeStamp;

				*(nint*)(__InBuffer + 4) = ServerRootMotion?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bHasAnimRootMotion;

				*(float*)(__InBuffer + 13) = ServerMontageTrackPosition;

				*(nint*)(__InBuffer + 17) = ServerLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = ServerRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 33) = ServerVelZ;

				*(nint*)(__InBuffer + 37) = ServerBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 45) = ServerBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 53) = bHasBase;

				*(bool*)(__InBuffer + 54) = bBaseRelativePosition;

				*(byte*)(__InBuffer + 55) = ServerMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAdjustRootMotionSourcePosition, __InBuffer);
			}
		}

		public virtual void ClientAdjustRootMotionPosition(float TimeStamp, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, UPrimitiveComponent ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[47];

				*(float*)(__InBuffer) = TimeStamp;

				*(float*)(__InBuffer + 4) = ServerMontageTrackPosition;

				*(nint*)(__InBuffer + 8) = ServerLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ServerRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = ServerVelZ;

				*(nint*)(__InBuffer + 28) = ServerBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = ServerBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 44) = bHasBase;

				*(bool*)(__InBuffer + 45) = bBaseRelativePosition;

				*(byte*)(__InBuffer + 46) = ServerMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAdjustRootMotionPosition, __InBuffer);
			}
		}

		public virtual void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[39];

				*(float*)(__InBuffer) = TimeStamp;

				*(nint*)(__InBuffer + 4) = NewLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = NewVel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = NewBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = NewBaseBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bHasBase;

				*(bool*)(__InBuffer + 37) = bBaseRelativePosition;

				*(byte*)(__InBuffer + 38) = ServerMovementMode;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAdjustPosition, __InBuffer);
			}
		}

		public virtual void ClientAckGoodMove(float TimeStamp)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = TimeStamp;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientAckGoodMove, __InBuffer);
			}
		}

		/// <returns>
		/// Whether the character can jump in the current state. 
		/// </returns>
		public virtual bool CanJumpInternal()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanJumpInternal, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Whether the character can jump in the current state. 
		/// </returns>
		public virtual bool CanJump()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanJump, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if this character is currently able to crouch (and is not currently crouched) */
		/// </returns>
		public virtual bool CanCrouch()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanCrouch, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetBaseTranslationOffset(), GetBaseRotationOffset()
		/// </see>
		public virtual void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MeshRelativeLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshRelativeRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CacheInitialMeshOffset, __InBuffer);
			}
		}

		private static uint __Mesh = 0;

		private static uint __CharacterMovement = 0;

		private static uint __CapsuleComponent = 0;

		private static uint __ArrowComponent = 0;

		private static uint __BasedMovement = 0;

		private static uint __ReplicatedBasedMovement = 0;

		private static uint __AnimRootMotionTranslationScale = 0;

		private static uint __BaseTranslationOffset = 0;

		private static uint __BaseRotationOffset = 0;

		private static uint __ReplicatedServerLastTransformUpdateTimeStamp = 0;

		private static uint __ReplayLastTransformUpdateTimeStamp = 0;

		private static uint __ReplicatedMovementMode = 0;

		private static uint __ReplicatedGravityDirection = 0;

		private static uint __bInBaseReplication = 0;

		private static uint __CrouchedEyeHeight = 0;

		private static uint __bIsCrouched = 0;

		private static uint __bProxyIsJumpForceApplied = 0;

		private static uint __bPressedJump = 0;

		private static uint __bClientUpdating = 0;

		private static uint __bClientWasFalling = 0;

		private static uint __bClientResimulateRootMotion = 0;

		private static uint __bClientResimulateRootMotionSources = 0;

		private static uint __bSimGravityDisabled = 0;

		private static uint __bClientCheckEncroachmentOnNetUpdate = 0;

		private static uint __bServerMoveIgnoreRootMotion = 0;

		private static uint __bWasJumping = 0;

		private static uint __JumpKeyHoldTime = 0;

		private static uint __JumpForceTimeRemaining = 0;

		private static uint __ProxyJumpForceStartedTime = 0;

		private static uint __JumpMaxHoldTime = 0;

		private static uint __JumpMaxCount = 0;

		private static uint __JumpCurrentCount = 0;

		private static uint __JumpCurrentCountPreJump = 0;

		private static uint __OnReachedJumpApex = 0;

		private static uint __LandedDelegate = 0;

		private static uint __MovementModeChangedDelegate = 0;

		private static uint __OnCharacterMovementUpdated = 0;

		private static uint __SavedRootMotion = 0;

		private static uint __ClientRootMotionParams = 0;

		private static uint __RootMotionRepMoves = 0;

		private static uint __RepRootMotion = 0;

		private static uint __UnCrouch = 0;

		private static uint __StopJumping = 0;

		private static uint __StopAnimMontage = 0;

		private static uint __ServerMovePacked = 0;

		private static uint __ServerMoveOld = 0;

		private static uint __ServerMoveNoBase = 0;

		private static uint __ServerMoveDualNoBase = 0;

		private static uint __ServerMoveDualHybridRootMotion = 0;

		private static uint __ServerMoveDual = 0;

		private static uint __ServerMove = 0;

		private static uint __RootMotionDebugClientPrintOnScreen = 0;

		private static uint __PlayAnimMontage = 0;

		private static uint __OnWalkingOffLedge = 0;

		private static uint __OnRep_RootMotion = 0;

		private static uint __OnRep_ReplicatedBasedMovement = 0;

		private static uint __OnRep_ReplayLastTransformUpdateTimeStamp = 0;

		private static uint __OnRep_IsCrouched = 0;

		private static uint __OnLaunched = 0;

		private static uint __OnLanded = 0;

		private static uint __OnJumped = 0;

		private static uint __LaunchCharacter = 0;

		private static uint __K2_UpdateCustomMovement = 0;

		private static uint __K2_OnStartCrouch = 0;

		private static uint __K2_OnMovementModeChanged = 0;

		private static uint __K2_OnEndCrouch = 0;

		private static uint __Jump = 0;

		private static uint __IsPlayingRootMotion = 0;

		private static uint __IsPlayingNetworkedRootMotionMontage = 0;

		private static uint __IsJumpProvidingForce = 0;

		private static uint __HasAnyRootMotion = 0;

		private static uint __GetCurrentMontage = 0;

		private static uint __GetBaseTranslationOffset = 0;

		private static uint __GetBaseRotationOffsetRotator = 0;

		private static uint __GetAnimRootMotionTranslationScale = 0;

		private static uint __Crouch = 0;

		private static uint __ClientVeryShortAdjustPosition = 0;

		private static uint __ClientMoveResponsePacked = 0;

		private static uint __ClientCheatWalk = 0;

		private static uint __ClientCheatGhost = 0;

		private static uint __ClientCheatFly = 0;

		private static uint __ClientAdjustRootMotionSourcePosition = 0;

		private static uint __ClientAdjustRootMotionPosition = 0;

		private static uint __ClientAdjustPosition = 0;

		private static uint __ClientAckGoodMove = 0;

		private static uint __CanJumpInternal = 0;

		private static uint __CanJump = 0;

		private static uint __CanCrouch = 0;

		private static uint __CacheInitialMeshOffset = 0;
	}
}