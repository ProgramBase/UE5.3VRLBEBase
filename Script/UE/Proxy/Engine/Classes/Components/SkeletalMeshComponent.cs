using Script.CoreUObject;
using Script.Library;
using Script.ClothingSystemRuntimeInterface;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshComponent")]
	public partial class USkeletalMeshComponent : USkinnedMeshComponent, IStaticClass, IInterface_CollisionDataProvider
	{
		public USkeletalMesh SkeletalMeshAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshAsset, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMeshAsset, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> AnimBlueprintGeneratedClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlueprintGeneratedClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlueprintGeneratedClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimInstance> AnimClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimClass, __ReturnBuffer);

					return *(TSubclassOf<UAnimInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimClass, __InBuffer);
				}
			}
		}

		public UAnimInstance AnimScriptInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimScriptInstance, __ReturnBuffer);

					return *(UAnimInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimScriptInstance, __InBuffer);
				}
			}
		}

		public TArray<UAnimInstance> SubInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubInstances, __ReturnBuffer);

					return *(TArray<UAnimInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubInstances, __InBuffer);
				}
			}
		}

		public UAnimInstance PostProcessAnimInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessAnimInstance, __ReturnBuffer);

					return *(UAnimInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessAnimInstance, __InBuffer);
				}
			}
		}

		public FSingleAnimationPlayData AnimationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationData, __ReturnBuffer);

					return *(FSingleAnimationPlayData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationData, __InBuffer);
				}
			}
		}

		public FVector RootBoneTranslation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootBoneTranslation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootBoneTranslation, __InBuffer);
				}
			}
		}

		public FVector LineCheckBoundsScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LineCheckBoundsScale, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LineCheckBoundsScale, __InBuffer);
				}
			}
		}

		public TArray<UAnimInstance> LinkedInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedInstances, __ReturnBuffer);

					return *(TArray<UAnimInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedInstances, __InBuffer);
				}
			}
		}

		public TArray<FTransform> CachedBoneSpaceTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedBoneSpaceTransforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedBoneSpaceTransforms, __InBuffer);
				}
			}
		}

		public TArray<FTransform> CachedComponentSpaceTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedComponentSpaceTransforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedComponentSpaceTransforms, __InBuffer);
				}
			}
		}

		public float GlobalAnimRateScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalAnimRateScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalAnimRateScale, __InBuffer);
				}
			}
		}

		public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KinematicBonesUpdateType, __ReturnBuffer);

					return *(EKinematicBonesUpdateToPhysics*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KinematicBonesUpdateType, __InBuffer);
				}
			}
		}

		public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsTransformUpdateMode, __ReturnBuffer);

					return *(EPhysicsTransformUpdateMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsTransformUpdateMode, __InBuffer);
				}
			}
		}

		public EAnimationMode AnimationMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationMode, __ReturnBuffer);

					return *(EAnimationMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationMode, __InBuffer);
				}
			}
		}

		public bool bDisablePostProcessBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisablePostProcessBlueprint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisablePostProcessBlueprint, __InBuffer);
				}
			}
		}

		public bool bUpdateOverlapsOnAnimationFinalize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateOverlapsOnAnimationFinalize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateOverlapsOnAnimationFinalize, __InBuffer);
				}
			}
		}

		public bool bHasValidBodies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasValidBodies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasValidBodies, __InBuffer);
				}
			}
		}

		public bool bBlendPhysics
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBlendPhysics, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBlendPhysics, __InBuffer);
				}
			}
		}

		public bool bEnablePhysicsOnDedicatedServer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsOnDedicatedServer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePhysicsOnDedicatedServer, __InBuffer);
				}
			}
		}

		public bool bUpdateMeshWhenKinematic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateMeshWhenKinematic, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateMeshWhenKinematic, __InBuffer);
				}
			}
		}

		public bool bUpdateJointsFromAnimation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateJointsFromAnimation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateJointsFromAnimation, __InBuffer);
				}
			}
		}

		public bool bAllowClothActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowClothActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowClothActors, __InBuffer);
				}
			}
		}

		public bool bDisableClothSimulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableClothSimulation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableClothSimulation, __InBuffer);
				}
			}
		}

		public bool bDisableRigidBodyAnimNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableRigidBodyAnimNode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableRigidBodyAnimNode, __InBuffer);
				}
			}
		}

		public bool bAllowAnimCurveEvaluation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowAnimCurveEvaluation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowAnimCurveEvaluation, __InBuffer);
				}
			}
		}

		public bool bCollideWithEnvironment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCollideWithEnvironment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCollideWithEnvironment, __InBuffer);
				}
			}
		}

		public bool bCollideWithAttachedChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCollideWithAttachedChildren, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCollideWithAttachedChildren, __InBuffer);
				}
			}
		}

		public bool bForceCollisionUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceCollisionUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceCollisionUpdate, __InBuffer);
				}
			}
		}

		public bool bLocalSpaceSimulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLocalSpaceSimulation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLocalSpaceSimulation, __InBuffer);
				}
			}
		}

		public bool bResetAfterTeleport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bResetAfterTeleport, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bResetAfterTeleport, __InBuffer);
				}
			}
		}

		public bool bDeferKinematicBoneUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDeferKinematicBoneUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDeferKinematicBoneUpdate, __InBuffer);
				}
			}
		}

		public bool bNoSkeletonUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNoSkeletonUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNoSkeletonUpdate, __InBuffer);
				}
			}
		}

		public bool bPauseAnims
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPauseAnims, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPauseAnims, __InBuffer);
				}
			}
		}

		public bool bUseRefPoseOnInitAnim
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRefPoseOnInitAnim, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRefPoseOnInitAnim, __InBuffer);
				}
			}
		}

		public bool bEnablePerPolyCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePerPolyCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePerPolyCollision, __InBuffer);
				}
			}
		}

		public bool bForceRefpose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceRefpose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceRefpose, __InBuffer);
				}
			}
		}

		public bool bOnlyAllowAutonomousTickPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyAllowAutonomousTickPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlyAllowAutonomousTickPose, __InBuffer);
				}
			}
		}

		public bool bIsAutonomousTickPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsAutonomousTickPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsAutonomousTickPose, __InBuffer);
				}
			}
		}

		public bool bOldForceRefPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOldForceRefPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOldForceRefPose, __InBuffer);
				}
			}
		}

		public bool bShowPrePhysBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPrePhysBones, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPrePhysBones, __InBuffer);
				}
			}
		}

		public bool bRequiredBonesUpToDate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRequiredBonesUpToDate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRequiredBonesUpToDate, __InBuffer);
				}
			}
		}

		public bool bAnimTreeInitialised
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAnimTreeInitialised, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAnimTreeInitialised, __InBuffer);
				}
			}
		}

		public bool bIncludeComponentLocationIntoBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludeComponentLocationIntoBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIncludeComponentLocationIntoBounds, __InBuffer);
				}
			}
		}

		public bool bEnableLineCheckWithBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLineCheckWithBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLineCheckWithBounds, __InBuffer);
				}
			}
		}

		public bool bPropagateCurvesToFollowers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPropagateCurvesToFollowers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPropagateCurvesToFollowers, __InBuffer);
				}
			}
		}

		public bool bSkipKinematicUpdateWhenInterpolating
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipKinematicUpdateWhenInterpolating, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipKinematicUpdateWhenInterpolating, __InBuffer);
				}
			}
		}

		public bool bSkipBoundsUpdateWhenInterpolating
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipBoundsUpdateWhenInterpolating, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSkipBoundsUpdateWhenInterpolating, __InBuffer);
				}
			}
		}

		public bool bUpdateAnimationInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateAnimationInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateAnimationInEditor, __InBuffer);
				}
			}
		}

		public bool bUpdateClothInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateClothInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateClothInEditor, __InBuffer);
				}
			}
		}

		public bool bOverrideDefaultAnimatingRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideDefaultAnimatingRig, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideDefaultAnimatingRig, __InBuffer);
				}
			}
		}

		public bool bNeedsQueuedAnimEventsDispatched
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNeedsQueuedAnimEventsDispatched, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNeedsQueuedAnimEventsDispatched, __InBuffer);
				}
			}
		}

		public ushort CachedAnimCurveUidVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedAnimCurveUidVersion, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedAnimCurveUidVersion, __InBuffer);
				}
			}
		}

		public float ClothBlendWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothBlendWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothBlendWeight, __InBuffer);
				}
			}
		}

		public bool bWaitForParallelClothTask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWaitForParallelClothTask, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWaitForParallelClothTask, __InBuffer);
				}
			}
		}

		public bool bFilteredAnimCurvesIsAllowList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFilteredAnimCurvesIsAllowList, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFilteredAnimCurvesIsAllowList, __InBuffer);
				}
			}
		}

		public ushort CachedMeshCurveMetaDataVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMeshCurveMetaDataVersion, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMeshCurveMetaDataVersion, __InBuffer);
				}
			}
		}

		public TArray<FName> FilteredAnimCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilteredAnimCurves, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilteredAnimCurves, __InBuffer);
				}
			}
		}

		public UBodySetup BodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __InBuffer);
				}
			}
		}

		public float ClothMaxDistanceScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothMaxDistanceScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothMaxDistanceScale, __InBuffer);
				}
			}
		}

		public FConstraintBrokenSignature OnConstraintBroken
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintBroken, __ReturnBuffer);

					return *(FConstraintBrokenSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintBroken, __InBuffer);
				}
			}
		}

		public FPlasticDeformationEventSignature OnPlasticDeformation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlasticDeformation, __ReturnBuffer);

					return *(FPlasticDeformationEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlasticDeformation, __InBuffer);
				}
			}
		}

		public TSubclassOf<UClothingSimulationFactory> ClothingSimulationFactory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothingSimulationFactory, __ReturnBuffer);

					return *(TSubclassOf<UClothingSimulationFactory>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothingSimulationFactory, __InBuffer);
				}
			}
		}

		public float TeleportDistanceThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportDistanceThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportDistanceThreshold, __InBuffer);
				}
			}
		}

		public float TeleportRotationThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportRotationThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportRotationThreshold, __InBuffer);
				}
			}
		}

		public uint LastPoseTickFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastPoseTickFrame, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastPoseTickFrame, __InBuffer);
				}
			}
		}

		public UClothingSimulationInteractor ClothingInteractor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothingInteractor, __ReturnBuffer);

					return *(UClothingSimulationInteractor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothingInteractor, __InBuffer);
				}
			}
		}

		public FOnAnimInitialized OnAnimInitialized
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAnimInitialized, __ReturnBuffer);

					return *(FOnAnimInitialized*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAnimInitialized, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UObject> DefaultAnimatingRigOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAnimatingRigOverride, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAnimatingRigOverride, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SkeletalMeshComponent");
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

		public virtual void UnlinkAnimClassLayers(TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnlinkAnimClassLayers, __InBuffer);
			}
		}

		/// <param name="bRestoreSimulationSpace">
		/// if true and the leader pose cloth was originally simulating in world
		/// space, we will restore this setting. This will cause the leader component to reset which may be
		/// undesirable.
		/// </param>
		public virtual void UnbindClothFromLeaderPoseComponent(bool bRestoreSimulationSpace = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bRestoreSimulationSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindClothFromLeaderPoseComponent, __InBuffer);
			}
		}

		public virtual void ToggleDisablePostProcessBlueprint()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleDisablePostProcessBlueprint);
			}
		}

		public virtual void TermBodiesBelow(FName ParentBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParentBoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __TermBodiesBelow, __InBuffer);
			}
		}

		public virtual void SuspendClothingSimulation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SuspendClothingSimulation);
			}
		}

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void SnapshotPose(ref FPoseSnapshot Snapshot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Snapshot?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SnapshotPose, __InBuffer, __OutBuffer);

				Snapshot = *(FPoseSnapshot*)(__OutBuffer);

			}
		}

		public virtual void SetUpdateClothInEditor(bool NewUpdateState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewUpdateState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUpdateClothInEditor, __InBuffer);
			}
		}

		public virtual void SetUpdateAnimationInEditor(bool NewUpdateState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewUpdateState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUpdateAnimationInEditor, __InBuffer);
			}
		}

		/// <param name="threshold">
		/// Threshold in degrees.
		/// </param>
		public virtual void SetTeleportRotationThreshold(float Threshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Threshold;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTeleportRotationThreshold, __InBuffer);
			}
		}

		/// <param name="threshold">
		/// Threshold value.
		/// </param>
		public virtual void SetTeleportDistanceThreshold(float Threshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Threshold;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTeleportDistanceThreshold, __InBuffer);
			}
		}

		public virtual void SetSkeletalMeshAsset(USkeletalMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkeletalMeshAsset, __InBuffer);
			}
		}

		public virtual void SetPosition(float InPos, bool bFireNotifies = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InPos;

				*(bool*)(__InBuffer + 4) = bFireNotifies;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPosition, __InBuffer);
			}
		}

		public virtual void SetPlayRate(float Rate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Rate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlayRate, __InBuffer);
			}
		}

		public virtual void SetPhysicsBlendWeight(float PhysicsBlendWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = PhysicsBlendWeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsBlendWeight, __InBuffer);
			}
		}

		/// <param name="bNewNotifyRigidBodyCollision">
		/// The value to assign to bNotifyRigidBodyCollision
		/// </param>
		/// <param name="BoneName">
		/// Name of the body to turn hit notifies on (and below)
		/// </param>
		/// <param name="bIncludeSelf">
		/// Whether to modify the given body (useful for roots with multiple children)
		/// </param>
		public virtual void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision, FName BoneName = null, bool bIncludeSelf = true)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[10];

				*(bool*)(__InBuffer) = bNewNotifyRigidBodyCollision;

				*(nint*)(__InBuffer + 1) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 9) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyRigidBodyCollisionBelow, __InBuffer);
			}
		}

		/// <param name="bRemoveZeroWeight">
		/// : Used by editor code when it should stay in the active list with zero weight
		/// </param>
		public virtual void SetMorphTarget(FName MorphTargetName, float Value, bool bRemoveZeroWeight = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = MorphTargetName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				*(bool*)(__InBuffer + 12) = bRemoveZeroWeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMorphTarget, __InBuffer);
			}
		}

		public virtual void SetEnablePhysicsBlending(bool bNewBlendPhysics)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewBlendPhysics;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnablePhysicsBlending, __InBuffer);
			}
		}

		/// <param name="bEnableGravity">
		/// Whether gravity should be enabled or disabled.
		/// </param>
		/// <param name="BoneName">
		/// The name of the top most bone.
		/// </param>
		/// <param name="bIncludeSelf">
		/// Whether the bone specified should be edited.
		/// </param>
		public virtual void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity, FName BoneName, bool bIncludeSelf = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(bool*)(__InBuffer) = bEnableGravity;

				*(nint*)(__InBuffer + 1) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 9) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableGravityOnAllBodiesBelow, __InBuffer);
			}
		}

		/// <param name="bEnableGravity">
		/// Whether gravity should be enabled or disabled.
		/// </param>
		/// <param name="BoneName">
		/// The name of the bone to modify.
		/// </param>
		public virtual void SetEnableBodyGravity(bool bEnableGravity, FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bEnableGravity;

				*(nint*)(__InBuffer + 1) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableBodyGravity, __InBuffer);
			}
		}

		public virtual void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInDisablePostProcess;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisablePostProcessBlueprint, __InBuffer);
			}
		}

		public virtual void SetDisableAnimCurves(bool bInDisableAnimCurves)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInDisableAnimCurves;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisableAnimCurves, __InBuffer);
			}
		}

		public virtual void SetDefaultAnimatingRigOverride(TSoftObjectPtr<UObject> InAnimatingRig)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimatingRig?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultAnimatingRigOverride, __InBuffer);
			}
		}

		public virtual void SetConstraintProfileForAll(FName ProfileName, bool bDefaultIfNotFound = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDefaultIfNotFound;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintProfileForAll, __InBuffer);
			}
		}

		public virtual void SetConstraintProfile(FName JointName, FName ProfileName, bool bDefaultIfNotFound = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = JointName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bDefaultIfNotFound;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintProfile, __InBuffer);
			}
		}

		public virtual void SetClothMaxDistanceScale(float Scale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Scale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetClothMaxDistanceScale, __InBuffer);
			}
		}

		/// <param name="bNewNotifyRigidBodyCollision">
		/// The value to assign to bNotifyRigidBodyCollision
		/// </param>
		/// <param name="BoneName">
		/// Name of the body to turn hit notifies on/off. None implies root body
		/// </param>
		public virtual void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision, FName BoneName = null)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bNewNotifyRigidBodyCollision;

				*(nint*)(__InBuffer + 1) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBodyNotifyRigidBodyCollision, __InBuffer);
			}
		}

		public virtual void SetAnimClass(UClass NewClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimClass, __InBuffer);
			}
		}

		/// <param name="InAnimationMode">
		/// : Requested AnimationMode
		/// </param>
		/// <param name="bForceInitAnimScriptInstance">
		/// : Init AnimScriptInstance if the AnimationMode is AnimationBlueprint even if the new animation mode is the same as current (this allows to use BP construction script to do this)
		/// </param>
		public virtual void SetAnimationMode(EAnimationMode InAnimationMode, bool bForceInitAnimScriptInstance = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)InAnimationMode;

				*(bool*)(__InBuffer + 1) = bForceInitAnimScriptInstance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimationMode, __InBuffer);
			}
		}

		public virtual void SetAnimation(UAnimationAsset NewAnimToPlay)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewAnimToPlay?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimation, __InBuffer);
			}
		}

		/// <param name="InBoneName">
		/// Name of bone to adjust constraint ranges for
		/// </param>
		/// <param name="Swing1LimitAngle">
		/// Size of limit in degrees, 0 means locked, 180 means free
		/// </param>
		/// <param name="TwistLimitAngle">
		/// Size of limit in degrees, 0 means locked, 180 means free
		/// </param>
		/// <param name="Swing2LimitAngle">
		/// Size of limit in degrees, 0 means locked, 180 means free
		/// </param>
		public virtual void SetAngularLimits(FName InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Swing1LimitAngle;

				*(float*)(__InBuffer + 12) = TwistLimitAngle;

				*(float*)(__InBuffer + 16) = Swing2LimitAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularLimits, __InBuffer);
			}
		}

		public virtual void SetAllowRigidBodyAnimNode(bool bInAllow, bool bReinitAnim = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bInAllow;

				*(bool*)(__InBuffer + 1) = bReinitAnim;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowRigidBodyAnimNode, __InBuffer);
			}
		}

		public virtual void SetAllowedAnimCurvesEvaluation(TArray<FName> List, bool bAllow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = List?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowedAnimCurvesEvaluation, __InBuffer);
			}
		}

		/// <param name="bInAllow">
		/// Whether to allow the creation of cloth assets and simulation.
		/// </param>
		public virtual void SetAllowClothActors(bool bInAllow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInAllow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowClothActors, __InBuffer);
			}
		}

		public virtual void SetAllowAnimCurveEvaluation(bool bInAllow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInAllow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowAnimCurveEvaluation, __InBuffer);
			}
		}

		public virtual void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bEnableSwingDrive;

				*(bool*)(__InBuffer + 1) = bEnableTwistDrive;

				*(bool*)(__InBuffer + 2) = bSkipCustomPhysicsType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllMotorsAngularVelocityDrive, __InBuffer);
			}
		}

		public virtual void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bEnableSwingDrive;

				*(bool*)(__InBuffer + 1) = bEnableTwistDrive;

				*(bool*)(__InBuffer + 2) = bSkipCustomPhysicsType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllMotorsAngularPositionDrive, __InBuffer);
			}
		}

		public virtual void SetAllMotorsAngularDriveParams(float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = InSpring;

				*(float*)(__InBuffer + 4) = InDamping;

				*(float*)(__InBuffer + 8) = InForceLimit;

				*(bool*)(__InBuffer + 12) = bSkipCustomPhysicsType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllMotorsAngularDriveParams, __InBuffer);
			}
		}

		public virtual void SetAllBodiesSimulatePhysics(bool bNewSimulate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewSimulate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllBodiesSimulatePhysics, __InBuffer);
			}
		}

		public virtual void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight, bool bSkipCustomPhysicsType = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = PhysicsBlendWeight;

				*(bool*)(__InBuffer + 4) = bSkipCustomPhysicsType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllBodiesPhysicsBlendWeight, __InBuffer);
			}
		}

		public virtual void SetAllBodiesBelowSimulatePhysics(FName InBoneName, bool bNewSimulate, bool bIncludeSelf = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bNewSimulate;

				*(bool*)(__InBuffer + 9) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllBodiesBelowSimulatePhysics, __InBuffer);
			}
		}

		public virtual void SetAllBodiesBelowPhysicsDisabled(FName InBoneName, bool bDisabled, bool bIncludeSelf = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDisabled;

				*(bool*)(__InBuffer + 9) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllBodiesBelowPhysicsDisabled, __InBuffer);
			}
		}

		public virtual void SetAllBodiesBelowPhysicsBlendWeight(FName InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType = false, bool bIncludeSelf = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PhysicsBlendWeight;

				*(bool*)(__InBuffer + 12) = bSkipCustomPhysicsType;

				*(bool*)(__InBuffer + 13) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllBodiesBelowPhysicsBlendWeight, __InBuffer);
			}
		}

		public virtual void SetAllBodiesBelowLinearVelocity(FName InBoneName, FVector LinearVelocity, bool bIncludeSelf = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LinearVelocity?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllBodiesBelowLinearVelocity, __InBuffer);
			}
		}

		public virtual void ResumeClothingSimulation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResumeClothingSimulation);
			}
		}

		public virtual void ResetClothTeleportMode()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetClothTeleportMode);
			}
		}

		public virtual void ResetAnimInstanceDynamics(ETeleportType InTeleportType = ETeleportType.ResetPhysics)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTeleportType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetAnimInstanceDynamics, __InBuffer);
			}
		}

		public virtual void ResetAllowedAnimCurveEvaluation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetAllowedAnimCurveEvaluation);
			}
		}

		public virtual void ResetAllBodiesSimulatePhysics()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetAllBodiesSimulatePhysics);
			}
		}

		public virtual void PlayAnimation(UAnimationAsset NewAnimToPlay, bool bLooping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewAnimToPlay?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLooping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayAnimation, __InBuffer);
			}
		}

		public virtual void Play(bool bLooping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bLooping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Play, __InBuffer);
			}
		}

		public virtual void OverrideAnimationData(UAnimationAsset InAnimToPlay, bool bIsLooping = true, bool bIsPlaying = true, float Position = 0.000000f, float PlayRate = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = InAnimToPlay?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsLooping;

				*(bool*)(__InBuffer + 9) = bIsPlaying;

				*(float*)(__InBuffer + 10) = Position;

				*(float*)(__InBuffer + 14) = PlayRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OverrideAnimationData, __InBuffer);
			}
		}

		public virtual void LinkAnimGraphByTag(FName InTag, TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LinkAnimGraphByTag, __InBuffer);
			}
		}

		public virtual void LinkAnimClassLayers(TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LinkAnimClassLayers, __InBuffer);
			}
		}

		/// <param name="WorldPosition">
		/// The point we want the closest point to (i.e. for all bodies in the physics asset, find the one that has a point closest to WorldPosition)
		/// </param>
		/// <param name="ClosestPointOnPhysicsAsset">
		/// The data associated with the closest point (position, normal, etc...)
		/// </param>
		/// <returns>
		/// true if we found a closest point
		/// </returns>
		public virtual bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition, ref FVector ClosestWorldPosition, ref FVector Normal, ref FName BoneName, ref float Distance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClosestWorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Normal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Distance;

				var __OutBuffer = stackalloc byte[28];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_GetClosestPointOnPhysicsAsset, __InBuffer, __OutBuffer, __ReturnBuffer);

				ClosestWorldPosition = *(FVector*)(__OutBuffer);

				Normal = *(FVector*)(__OutBuffer + 8);

				BoneName = *(FName*)(__OutBuffer + 16);

				Distance = *(float*)(__OutBuffer + 24);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsClothingSimulationSuspended()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsClothingSimulationSuspended, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// The name of the bone to check.
		/// </param>
		/// <returns>
		/// True if gravity is enabled on the bone.
		/// </returns>
		public virtual bool IsBodyGravityEnabled(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsBodyGravityEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasValidAnimationInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasValidAnimationInstance, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="OutValue">
		/// (reference) Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetTransformAttribute_Ref(FName BoneName, FName AttributeName, ref FTransform OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetTransformAttribute_Ref, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="OutValue">
		/// (reference) Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetTransformAttribute(FName BoneName, FName AttributeName, FTransform DefaultValue, ref FTransform OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetTransformAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Threshold in degrees.
		/// </returns>
		public virtual float GetTeleportRotationThreshold()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTeleportRotationThreshold, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Threshold value.
		/// </returns>
		public virtual float GetTeleportDistanceThreshold()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTeleportDistanceThreshold, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="OutValue">
		/// (reference) Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetStringAttribute_Ref(FName BoneName, FName AttributeName, ref FString OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetStringAttribute_Ref, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="DefaultValue">
		/// In case the attribute could not be found
		/// </param>
		/// <param name="OutValue">
		/// Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetStringAttribute(FName BoneName, FName AttributeName, FString DefaultValue, ref FString OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetStringAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMesh GetSkeletalMeshAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeletalMeshAsset, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		public virtual FVector GetSkeletalCenterOfMass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeletalCenterOfMass, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual UAnimInstance GetPostProcessInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPostProcessInstance, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual float GetPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPosition, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPlayRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlayRate, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMorphTarget(FName MorphTargetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MorphTargetName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMorphTarget, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InGroup?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimLayerInstanceByGroup, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual UAnimInstance GetLinkedAnimLayerInstanceByClass(TSubclassOf<UAnimInstance> InClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimLayerInstanceByClass, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual void GetLinkedAnimGraphInstancesByTag(FName InTag, ref TArray<UAnimInstance> OutLinkedInstances)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutLinkedInstances?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLinkedAnimGraphInstancesByTag, __InBuffer, __OutBuffer);

				OutLinkedInstances = *(TArray<UAnimInstance>*)(__OutBuffer);

			}
		}

		public virtual UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLinkedAnimGraphInstanceByTag, __InBuffer, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="OutValue">
		/// (reference) Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetIntegerAttribute_Ref(FName BoneName, FName AttributeName, ref int OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = OutValue;

				*(byte*)(__InBuffer + 20) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetIntegerAttribute_Ref, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="DefaultValue">
		/// In case the attribute could not be found
		/// </param>
		/// <param name="OutValue">
		/// Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetIntegerAttribute(FName BoneName, FName AttributeName, int DefaultValue, ref int OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = DefaultValue;

				*(int*)(__InBuffer + 20) = OutValue;

				*(byte*)(__InBuffer + 24) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetIntegerAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="OutValue">
		/// (reference) Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetFloatAttribute_Ref(FName BoneName, FName AttributeName, ref float OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = OutValue;

				*(byte*)(__InBuffer + 20) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetFloatAttribute_Ref, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to retrieve try and retrieve the attribute from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute to retrieve
		/// </param>
		/// <param name="DefaultValue">
		/// In case the attribute could not be found
		/// </param>
		/// <param name="OutValue">
		/// Retrieved attribute value if found, otherwise is set to DefaultValue
		/// </param>
		/// <param name="LookupType">
		/// Determines how the attribute is retrieved from the specified BoneName (see ECustomBoneAttributeLookup)
		/// </param>
		/// <returns>
		/// Whether or not the atttribute was successfully retrieved
		/// </returns>
		public virtual bool GetFloatAttribute(FName BoneName, FName AttributeName, float DefaultValue, ref float OutValue, ECustomBoneAttributeLookup LookupType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DefaultValue;

				*(float*)(__InBuffer + 20) = OutValue;

				*(byte*)(__InBuffer + 24) = (byte)LookupType;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetFloatAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetDisablePostProcessBlueprint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDisablePostProcessBlueprint, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetDisableAnimCurves()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDisableAnimCurves, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TSoftObjectPtr<UObject> GetDefaultAnimatingRigOverride()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultAnimatingRigOverride, __ReturnBuffer);

				return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public virtual TSoftObjectPtr<UObject> GetDefaultAnimatingRig()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultAnimatingRig, __ReturnBuffer);

				return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// Name of bone to get constraint ranges for
		/// </param>
		/// <param name="Swing1Angle">
		/// current angular state of the constraint
		/// </param>
		/// <param name="TwistAngle">
		/// current angular state of the constraint
		/// </param>
		/// <param name="Swing2Angle">
		/// current angular state of the constraint
		/// </param>
		public virtual void GetCurrentJointAngles(FName InBoneName, ref float Swing1Angle, ref float TwistAngle, ref float Swing2Angle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Swing1Angle;

				*(float*)(__InBuffer + 12) = TwistAngle;

				*(float*)(__InBuffer + 16) = Swing2Angle;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCurrentJointAngles, __InBuffer, __OutBuffer);

				Swing1Angle = *(float*)(__OutBuffer);

				TwistAngle = *(float*)(__OutBuffer + 4);

				Swing2Angle = *(float*)(__OutBuffer + 8);

			}
		}

		/// <param name="BodyName">
		/// name of the body to get the attached constraints from 
		/// </param>
		/// <param name="bParentConstraints">
		/// return constraints where BodyName is the child of the constraint
		/// </param>
		/// <param name="bChildConstraints">
		/// return constraints where BodyName is the parent of the constraint
		/// </param>
		/// <param name="bParentConstraints">
		/// return constraints attached to the parent of the body 
		/// </param>
		/// <param name="IncludesTerminated">
		/// whether or not to return terminated constraints
		/// </param>
		/// <param name="OutConstraints">
		/// returned list of constraints matching the parameters
		/// </param>
		public virtual void GetConstraintsFromBody(FName BodyName, bool bParentConstraints, bool bChildConstraints, bool bIncludesTerminated, ref TArray<FConstraintInstanceAccessor> OutConstraints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = BodyName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bParentConstraints;

				*(bool*)(__InBuffer + 9) = bChildConstraints;

				*(bool*)(__InBuffer + 10) = bIncludesTerminated;

				*(nint*)(__InBuffer + 11) = OutConstraints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetConstraintsFromBody, __InBuffer, __OutBuffer);

				OutConstraints = *(TArray<FConstraintInstanceAccessor>*)(__OutBuffer);

			}
		}

		/// <param name="IncludesTerminated">
		/// whether or not to return terminated constraints
		/// </param>
		/// <param name="OutConstraints">
		/// returned list of constraints matching the parameters
		/// </param>
		public virtual void GetConstraints(bool bIncludesTerminated, ref TArray<FConstraintInstanceAccessor> OutConstraints)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bIncludesTerminated;

				*(nint*)(__InBuffer + 1) = OutConstraints?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetConstraints, __InBuffer, __OutBuffer);

				OutConstraints = *(TArray<FConstraintInstanceAccessor>*)(__OutBuffer);

			}
		}

		/// <param name="ConstraintName">
		/// name of the constraint
		/// </param>
		/// <param name="IncludesTerminated">
		/// whether or not to return a terminated constraint
		/// </param>
		public virtual FConstraintInstanceAccessor GetConstraintByName(FName ConstraintName, bool bIncludesTerminated)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ConstraintName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIncludesTerminated;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetConstraintByName, __InBuffer, __ReturnBuffer);

				return *(FConstraintInstanceAccessor*)__ReturnBuffer;
			}
		}

		public virtual float GetClothMaxDistanceScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetClothMaxDistanceScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UClothingSimulationInteractor GetClothingSimulationInteractor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetClothingSimulationInteractor, __ReturnBuffer);

				return *(UClothingSimulationInteractor*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the body to return. 'None' indicates root body.
		/// </param>
		/// <param name="bScaleMass">
		/// If true, the mass is scaled by the bone's MassScale.
		/// </param>
		public virtual float GetBoneMass(FName BoneName = null, bool bScaleMass = true)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bScaleMass;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBoneMass, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector GetBoneLinearVelocity(FName InBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneLinearVelocity, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual UAnimInstance GetAnimInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimInstance, __ReturnBuffer);

				return *(UAnimInstance*)__ReturnBuffer;
			}
		}

		public virtual UClass GetAnimClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual EAnimationMode GetAnimationMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnimationMode, __ReturnBuffer);

				return *(EAnimationMode*)__ReturnBuffer;
			}
		}

		public virtual bool GetAllowRigidBodyAnimNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAllowRigidBodyAnimNode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetAllowedAnimCurveEvaluate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAllowedAnimCurveEvaluate, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetAllowClothActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAllowClothActors, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ForceClothNextUpdateTeleportAndReset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForceClothNextUpdateTeleportAndReset);
			}
		}

		public virtual void ForceClothNextUpdateTeleport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForceClothNextUpdateTeleport);
			}
		}

		/// <param name="ConstraintIndex">
		/// Index of constraint to look for
		/// </param>
		/// <returns>
		/// Constraint Joint Name
		/// </returns>
		public virtual FName FindConstraintBoneName(int ConstraintIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ConstraintIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindConstraintBoneName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual void ClearMorphTargets()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearMorphTargets);
			}
		}

		/// <param name="Impulse">
		/// vector of impulse
		/// </param>
		/// <param name="HitLocation">
		/// location of the hit
		/// </param>
		/// <param name="InBoneName">
		/// Name of bone to break constraint for
		/// </param>
		public virtual void BreakConstraint(FVector Impulse, FVector HitLocation, FName InBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BreakConstraint, __InBuffer);
			}
		}

		/// <Note>
		/// This will FORCE any cloth actor on the leader component to simulate in local space. Also
		/// The meshes used in the components must be identical for the cloth to bind correctly
		/// </Note>
		public virtual void BindClothToLeaderPoseComponent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __BindClothToLeaderPoseComponent);
			}
		}

		public virtual void AllowAnimCurveEvaluation(FName NameOfCurve, bool bAllow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NameOfCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AllowAnimCurveEvaluation, __InBuffer);
			}
		}

		/// <param name="Impulse">
		/// Magnitude and direction of impulse to apply.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
		/// </param>
		/// <param name="bVelChange">
		/// If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).
		/// </param>
		/// <param name="bIncludeSelf">
		/// If false, Force is only applied to bodies below but not given bone name.
		/// </param>
		public virtual void AddImpulseToAllBodiesBelow(FVector Impulse, FName BoneName = null, bool bVelChange = false, bool bIncludeSelf = true)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Impulse?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bVelChange;

				*(bool*)(__InBuffer + 17) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddImpulseToAllBodiesBelow, __InBuffer);
			}
		}

		/// <param name="Force">
		/// Force vector to apply. Magnitude indicates strength of force.
		/// </param>
		/// <param name="BoneName">
		/// If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// </param>
		/// <param name="bAccelChange">
		/// If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).
		/// </param>
		/// <param name="bIncludeSelf">
		/// If false, Force is only applied to bodies below but not given bone name.
		/// </param>
		public virtual void AddForceToAllBodiesBelow(FVector Force, FName BoneName = null, bool bAccelChange = false, bool bIncludeSelf = true)
		{
			unsafe
			{
				BoneName ??= new FName("None");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Force?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAccelChange;

				*(bool*)(__InBuffer + 17) = bIncludeSelf;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddForceToAllBodiesBelow, __InBuffer);
			}
		}

		public virtual void AccumulateAllBodiesBelowPhysicsBlendWeight(FName InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AddPhysicsBlendWeight;

				*(bool*)(__InBuffer + 12) = bSkipCustomPhysicsType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AccumulateAllBodiesBelowPhysicsBlendWeight, __InBuffer);
			}
		}

		private static uint __SkeletalMeshAsset = 0;

		private static uint __AnimBlueprintGeneratedClass = 0;

		private static uint __AnimClass = 0;

		private static uint __AnimScriptInstance = 0;

		private static uint __SubInstances = 0;

		private static uint __PostProcessAnimInstance = 0;

		private static uint __AnimationData = 0;

		private static uint __RootBoneTranslation = 0;

		private static uint __LineCheckBoundsScale = 0;

		private static uint __LinkedInstances = 0;

		private static uint __CachedBoneSpaceTransforms = 0;

		private static uint __CachedComponentSpaceTransforms = 0;

		private static uint __GlobalAnimRateScale = 0;

		private static uint __KinematicBonesUpdateType = 0;

		private static uint __PhysicsTransformUpdateMode = 0;

		private static uint __AnimationMode = 0;

		private static uint __bDisablePostProcessBlueprint = 0;

		private static uint __bUpdateOverlapsOnAnimationFinalize = 0;

		private static uint __bHasValidBodies = 0;

		private static uint __bBlendPhysics = 0;

		private static uint __bEnablePhysicsOnDedicatedServer = 0;

		private static uint __bUpdateMeshWhenKinematic = 0;

		private static uint __bUpdateJointsFromAnimation = 0;

		private static uint __bAllowClothActors = 0;

		private static uint __bDisableClothSimulation = 0;

		private static uint __bDisableRigidBodyAnimNode = 0;

		private static uint __bAllowAnimCurveEvaluation = 0;

		private static uint __bCollideWithEnvironment = 0;

		private static uint __bCollideWithAttachedChildren = 0;

		private static uint __bForceCollisionUpdate = 0;

		private static uint __bLocalSpaceSimulation = 0;

		private static uint __bResetAfterTeleport = 0;

		private static uint __bDeferKinematicBoneUpdate = 0;

		private static uint __bNoSkeletonUpdate = 0;

		private static uint __bPauseAnims = 0;

		private static uint __bUseRefPoseOnInitAnim = 0;

		private static uint __bEnablePerPolyCollision = 0;

		private static uint __bForceRefpose = 0;

		private static uint __bOnlyAllowAutonomousTickPose = 0;

		private static uint __bIsAutonomousTickPose = 0;

		private static uint __bOldForceRefPose = 0;

		private static uint __bShowPrePhysBones = 0;

		private static uint __bRequiredBonesUpToDate = 0;

		private static uint __bAnimTreeInitialised = 0;

		private static uint __bIncludeComponentLocationIntoBounds = 0;

		private static uint __bEnableLineCheckWithBounds = 0;

		private static uint __bPropagateCurvesToFollowers = 0;

		private static uint __bSkipKinematicUpdateWhenInterpolating = 0;

		private static uint __bSkipBoundsUpdateWhenInterpolating = 0;

		private static uint __bUpdateAnimationInEditor = 0;

		private static uint __bUpdateClothInEditor = 0;

		private static uint __bOverrideDefaultAnimatingRig = 0;

		private static uint __bNeedsQueuedAnimEventsDispatched = 0;

		private static uint __CachedAnimCurveUidVersion = 0;

		private static uint __ClothBlendWeight = 0;

		private static uint __bWaitForParallelClothTask = 0;

		private static uint __bFilteredAnimCurvesIsAllowList = 0;

		private static uint __CachedMeshCurveMetaDataVersion = 0;

		private static uint __FilteredAnimCurves = 0;

		private static uint __BodySetup = 0;

		private static uint __ClothMaxDistanceScale = 0;

		private static uint __OnConstraintBroken = 0;

		private static uint __OnPlasticDeformation = 0;

		private static uint __ClothingSimulationFactory = 0;

		private static uint __TeleportDistanceThreshold = 0;

		private static uint __TeleportRotationThreshold = 0;

		private static uint __LastPoseTickFrame = 0;

		private static uint __ClothingInteractor = 0;

		private static uint __OnAnimInitialized = 0;

		private static uint __DefaultAnimatingRigOverride = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UnlinkAnimClassLayers = 0;

		private static uint __UnbindClothFromLeaderPoseComponent = 0;

		private static uint __ToggleDisablePostProcessBlueprint = 0;

		private static uint __TermBodiesBelow = 0;

		private static uint __SuspendClothingSimulation = 0;

		private static uint __Stop = 0;

		private static uint __SnapshotPose = 0;

		private static uint __SetUpdateClothInEditor = 0;

		private static uint __SetUpdateAnimationInEditor = 0;

		private static uint __SetTeleportRotationThreshold = 0;

		private static uint __SetTeleportDistanceThreshold = 0;

		private static uint __SetSkeletalMeshAsset = 0;

		private static uint __SetPosition = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetPhysicsBlendWeight = 0;

		private static uint __SetNotifyRigidBodyCollisionBelow = 0;

		private static uint __SetMorphTarget = 0;

		private static uint __SetEnablePhysicsBlending = 0;

		private static uint __SetEnableGravityOnAllBodiesBelow = 0;

		private static uint __SetEnableBodyGravity = 0;

		private static uint __SetDisablePostProcessBlueprint = 0;

		private static uint __SetDisableAnimCurves = 0;

		private static uint __SetDefaultAnimatingRigOverride = 0;

		private static uint __SetConstraintProfileForAll = 0;

		private static uint __SetConstraintProfile = 0;

		private static uint __SetClothMaxDistanceScale = 0;

		private static uint __SetBodyNotifyRigidBodyCollision = 0;

		private static uint __SetAnimClass = 0;

		private static uint __SetAnimationMode = 0;

		private static uint __SetAnimation = 0;

		private static uint __SetAngularLimits = 0;

		private static uint __SetAllowRigidBodyAnimNode = 0;

		private static uint __SetAllowedAnimCurvesEvaluation = 0;

		private static uint __SetAllowClothActors = 0;

		private static uint __SetAllowAnimCurveEvaluation = 0;

		private static uint __SetAllMotorsAngularVelocityDrive = 0;

		private static uint __SetAllMotorsAngularPositionDrive = 0;

		private static uint __SetAllMotorsAngularDriveParams = 0;

		private static uint __SetAllBodiesSimulatePhysics = 0;

		private static uint __SetAllBodiesPhysicsBlendWeight = 0;

		private static uint __SetAllBodiesBelowSimulatePhysics = 0;

		private static uint __SetAllBodiesBelowPhysicsDisabled = 0;

		private static uint __SetAllBodiesBelowPhysicsBlendWeight = 0;

		private static uint __SetAllBodiesBelowLinearVelocity = 0;

		private static uint __ResumeClothingSimulation = 0;

		private static uint __ResetClothTeleportMode = 0;

		private static uint __ResetAnimInstanceDynamics = 0;

		private static uint __ResetAllowedAnimCurveEvaluation = 0;

		private static uint __ResetAllBodiesSimulatePhysics = 0;

		private static uint __PlayAnimation = 0;

		private static uint __Play = 0;

		private static uint __OverrideAnimationData = 0;

		private static uint __LinkAnimGraphByTag = 0;

		private static uint __LinkAnimClassLayers = 0;

		private static uint __K2_GetClosestPointOnPhysicsAsset = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsClothingSimulationSuspended = 0;

		private static uint __IsBodyGravityEnabled = 0;

		private static uint __HasValidAnimationInstance = 0;

		private static uint __GetTransformAttribute_Ref = 0;

		private static uint __GetTransformAttribute = 0;

		private static uint __GetTeleportRotationThreshold = 0;

		private static uint __GetTeleportDistanceThreshold = 0;

		private static uint __GetStringAttribute_Ref = 0;

		private static uint __GetStringAttribute = 0;

		private static uint __GetSkeletalMeshAsset = 0;

		private static uint __GetSkeletalCenterOfMass = 0;

		private static uint __GetPostProcessInstance = 0;

		private static uint __GetPosition = 0;

		private static uint __GetPlayRate = 0;

		private static uint __GetMorphTarget = 0;

		private static uint __GetLinkedAnimLayerInstanceByGroup = 0;

		private static uint __GetLinkedAnimLayerInstanceByClass = 0;

		private static uint __GetLinkedAnimGraphInstancesByTag = 0;

		private static uint __GetLinkedAnimGraphInstanceByTag = 0;

		private static uint __GetIntegerAttribute_Ref = 0;

		private static uint __GetIntegerAttribute = 0;

		private static uint __GetFloatAttribute_Ref = 0;

		private static uint __GetFloatAttribute = 0;

		private static uint __GetDisablePostProcessBlueprint = 0;

		private static uint __GetDisableAnimCurves = 0;

		private static uint __GetDefaultAnimatingRigOverride = 0;

		private static uint __GetDefaultAnimatingRig = 0;

		private static uint __GetCurrentJointAngles = 0;

		private static uint __GetConstraintsFromBody = 0;

		private static uint __GetConstraints = 0;

		private static uint __GetConstraintByName = 0;

		private static uint __GetClothMaxDistanceScale = 0;

		private static uint __GetClothingSimulationInteractor = 0;

		private static uint __GetBoneMass = 0;

		private static uint __GetBoneLinearVelocity = 0;

		private static uint __GetAnimInstance = 0;

		private static uint __GetAnimClass = 0;

		private static uint __GetAnimationMode = 0;

		private static uint __GetAllowRigidBodyAnimNode = 0;

		private static uint __GetAllowedAnimCurveEvaluate = 0;

		private static uint __GetAllowClothActors = 0;

		private static uint __ForceClothNextUpdateTeleportAndReset = 0;

		private static uint __ForceClothNextUpdateTeleport = 0;

		private static uint __FindConstraintBoneName = 0;

		private static uint __ClearMorphTargets = 0;

		private static uint __BreakConstraint = 0;

		private static uint __BindClothToLeaderPoseComponent = 0;

		private static uint __AllowAnimCurveEvaluation = 0;

		private static uint __AddImpulseToAllBodiesBelow = 0;

		private static uint __AddForceToAllBodiesBelow = 0;

		private static uint __AccumulateAllBodiesBelowPhysicsBlendWeight = 0;
	}
}