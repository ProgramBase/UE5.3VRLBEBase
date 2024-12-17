using Script.CoreUObject;
using Script.Engine;
using Script.ChaosSolverEngine;
using Script.FieldSystemEngine;
using Script.Chaos;
using Script.GeometryCollectionEngine.GeometryCollectionComponent;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionComponent")]
	public partial class UGeometryCollectionComponent : UMeshComponent, IStaticClass, IChaosNotifyHandlerInterface
	{
		public AChaosSolverActor ChaosSolverActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosSolverActor, __ReturnBuffer);

					return *(AChaosSolverActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosSolverActor, __InBuffer);
				}
			}
		}

		public UGeometryCollection RestCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RestCollection, __ReturnBuffer);

					return *(UGeometryCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RestCollection, __InBuffer);
				}
			}
		}

		public TArray<AFieldSystemActor> InitializationFields
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitializationFields, __ReturnBuffer);

					return *(TArray<AFieldSystemActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitializationFields, __InBuffer);
				}
			}
		}

		public EObjectStateTypeEnum ObjectType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectType, __ReturnBuffer);

					return *(EObjectStateTypeEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectType, __InBuffer);
				}
			}
		}

		public int GravityGroupIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GravityGroupIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GravityGroupIndex, __InBuffer);
				}
			}
		}

		public bool bForceMotionBlur
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMotionBlur, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMotionBlur, __InBuffer);
				}
			}
		}

		public bool EnableClustering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnableClustering, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnableClustering, __InBuffer);
				}
			}
		}

		public int ClusterGroupIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterGroupIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterGroupIndex, __InBuffer);
				}
			}
		}

		public int MaxClusterLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxClusterLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxClusterLevel, __InBuffer);
				}
			}
		}

		public int MaxSimulatedLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulatedLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulatedLevel, __InBuffer);
				}
			}
		}

		public EDamageModelTypeEnum DamageModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DamageModel, __ReturnBuffer);

					return *(EDamageModelTypeEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DamageModel, __InBuffer);
				}
			}
		}

		public TArray<float> DamageThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DamageThreshold, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DamageThreshold, __InBuffer);
				}
			}
		}

		public bool bUseSizeSpecificDamageThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSizeSpecificDamageThreshold, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSizeSpecificDamageThreshold, __InBuffer);
				}
			}
		}

		public FGeometryCollectionDamagePropagationData DamagePropagationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DamagePropagationData, __ReturnBuffer);

					return *(FGeometryCollectionDamagePropagationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DamagePropagationData, __InBuffer);
				}
			}
		}

		public bool bEnableDamageFromCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDamageFromCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDamageFromCollision, __InBuffer);
				}
			}
		}

		public bool bAllowRemovalOnSleep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRemovalOnSleep, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRemovalOnSleep, __InBuffer);
				}
			}
		}

		public bool bAllowRemovalOnBreak
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRemovalOnBreak, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowRemovalOnBreak, __InBuffer);
				}
			}
		}

		public int CollisionGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionGroup, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionGroup, __InBuffer);
				}
			}
		}

		public float CollisionSampleFraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionSampleFraction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionSampleFraction, __InBuffer);
				}
			}
		}

		public EInitialVelocityTypeEnum InitialVelocityType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialVelocityType, __ReturnBuffer);

					return *(EInitialVelocityTypeEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialVelocityType, __InBuffer);
				}
			}
		}

		public FVector InitialLinearVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialLinearVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialLinearVelocity, __InBuffer);
				}
			}
		}

		public FVector InitialAngularVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialAngularVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialAngularVelocity, __InBuffer);
				}
			}
		}

		public FGeomComponentCacheParameters CacheParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheParameters, __ReturnBuffer);

					return *(FGeomComponentCacheParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheParameters, __InBuffer);
				}
			}
		}

		public TArray<FTransform> RestTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RestTransforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RestTransforms, __InBuffer);
				}
			}
		}

		public FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyGeometryCollectionPhysicsStateChange, __ReturnBuffer);

					return *(FNotifyGeometryCollectionPhysicsStateChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyGeometryCollectionPhysicsStateChange, __InBuffer);
				}
			}
		}

		public FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyGeometryCollectionPhysicsLoadingStateChange, __ReturnBuffer);

					return *(FNotifyGeometryCollectionPhysicsLoadingStateChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NotifyGeometryCollectionPhysicsLoadingStateChange, __InBuffer);
				}
			}
		}

		public FOnChaosBreakEvent OnChaosBreakEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosBreakEvent, __ReturnBuffer);

					return *(FOnChaosBreakEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosBreakEvent, __InBuffer);
				}
			}
		}

		public FOnChaosRemovalEvent OnChaosRemovalEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosRemovalEvent, __ReturnBuffer);

					return *(FOnChaosRemovalEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosRemovalEvent, __InBuffer);
				}
			}
		}

		public FOnChaosCrumblingEvent OnChaosCrumblingEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosCrumblingEvent, __ReturnBuffer);

					return *(FOnChaosCrumblingEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosCrumblingEvent, __InBuffer);
				}
			}
		}

		public float DesiredCacheTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredCacheTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredCacheTime, __InBuffer);
				}
			}
		}

		public bool CachePlayback
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachePlayback, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachePlayback, __InBuffer);
				}
			}
		}

		public FOnChaosPhysicsCollision OnChaosPhysicsCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosPhysicsCollision, __ReturnBuffer);

					return *(FOnChaosPhysicsCollision*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnChaosPhysicsCollision, __InBuffer);
				}
			}
		}

		public bool bNotifyBreaks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyBreaks, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyBreaks, __InBuffer);
				}
			}
		}

		public bool bNotifyCollisions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyCollisions, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyCollisions, __InBuffer);
				}
			}
		}

		public bool bNotifyTrailing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyTrailing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyTrailing, __InBuffer);
				}
			}
		}

		public bool bNotifyRemovals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyRemovals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyRemovals, __InBuffer);
				}
			}
		}

		public bool bNotifyCrumblings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyCrumblings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyCrumblings, __InBuffer);
				}
			}
		}

		public bool bCrumblingEventIncludesChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCrumblingEventIncludesChildren, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCrumblingEventIncludesChildren, __InBuffer);
				}
			}
		}

		public bool bNotifyGlobalBreaks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalBreaks, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalBreaks, __InBuffer);
				}
			}
		}

		public bool bNotifyGlobalCollisions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalCollisions, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalCollisions, __InBuffer);
				}
			}
		}

		public bool bNotifyGlobalRemovals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalRemovals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalRemovals, __InBuffer);
				}
			}
		}

		public bool bNotifyGlobalCrumblings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalCrumblings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNotifyGlobalCrumblings, __InBuffer);
				}
			}
		}

		public bool bGlobalCrumblingEventIncludesChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGlobalCrumblingEventIncludesChildren, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGlobalCrumblingEventIncludesChildren, __InBuffer);
				}
			}
		}

		public bool bStoreVelocities
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStoreVelocities, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStoreVelocities, __InBuffer);
				}
			}
		}

		public bool bShowBoneColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowBoneColors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowBoneColors, __InBuffer);
				}
			}
		}

		public bool bUseRootProxyForNavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRootProxyForNavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseRootProxyForNavigation, __InBuffer);
				}
			}
		}

		public bool bUpdateNavigationInTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateNavigationInTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateNavigationInTick, __InBuffer);
				}
			}
		}

		public bool bEnableRunTimeDataCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRunTimeDataCollection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRunTimeDataCollection, __InBuffer);
				}
			}
		}

		public FGuid RunTimeDataCollectionGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RunTimeDataCollectionGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RunTimeDataCollectionGuid, __InBuffer);
				}
			}
		}

		public bool bOverrideCustomRenderer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideCustomRenderer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideCustomRenderer, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> CustomRendererType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomRendererType, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomRendererType, __InBuffer);
				}
			}
		}

		public UGeometryCollectionExternalRenderInterface CustomRenderer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomRenderer, __ReturnBuffer);

					return *(UGeometryCollectionExternalRenderInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomRenderer, __InBuffer);
				}
			}
		}

		public bool bEnableReplication
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableReplication, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableReplication, __InBuffer);
				}
			}
		}

		public bool bEnableAbandonAfterLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAbandonAfterLevel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableAbandonAfterLevel, __InBuffer);
				}
			}
		}

		public FName AbandonedCollisionProfileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AbandonedCollisionProfileName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AbandonedCollisionProfileName, __InBuffer);
				}
			}
		}

		public TArray<FName> CollisionProfilePerLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionProfilePerLevel, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionProfilePerLevel, __InBuffer);
				}
			}
		}

		public int ReplicationAbandonAfterLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicationAbandonAfterLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicationAbandonAfterLevel, __InBuffer);
				}
			}
		}

		public int ReplicationMaxPositionAndVelocityCorrectionLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicationMaxPositionAndVelocityCorrectionLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicationMaxPositionAndVelocityCorrectionLevel, __InBuffer);
				}
			}
		}

		public FGeometryCollectionRepData RepData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepData, __ReturnBuffer);

					return *(FGeometryCollectionRepData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepData, __InBuffer);
				}
			}
		}

		public TArray<int> SelectedBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedBones, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedBones, __InBuffer);
				}
			}
		}

		public TArray<int> HighlightedBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HighlightedBones, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HighlightedBones, __InBuffer);
				}
			}
		}

		public UBodySetup DummyBodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DummyBodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DummyBodySetup, __InBuffer);
				}
			}
		}

		public AActor EditorActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorActor, __InBuffer);
				}
			}
		}

		public UChaosGameplayEventDispatcher EventDispatcher
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EventDispatcher, __ReturnBuffer);

					return *(UChaosGameplayEventDispatcher*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EventDispatcher, __InBuffer);
				}
			}
		}

		public TArray<UInstancedStaticMeshComponent> EmbeddedGeometryComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmbeddedGeometryComponents, __ReturnBuffer);

					return *(TArray<UInstancedStaticMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmbeddedGeometryComponents, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEngine.GeometryCollectionComponent");
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

		public virtual void SetRestCollection(UGeometryCollection RestCollectionIn, bool bApplyAssetDefaults = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = RestCollectionIn?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bApplyAssetDefaults;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRestCollection, __InBuffer);
			}
		}

		public virtual void SetPerParticleCollisionProfileName(TArray<int> BoneIds, FName ProfileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BoneIds?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPerParticleCollisionProfileName, __InBuffer);
			}
		}

		public virtual void SetPerLevelCollisionProfileNames(TArray<FName> ProfileNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ProfileNames?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPerLevelCollisionProfileNames, __InBuffer);
			}
		}

		public virtual void SetNotifyRemovals(bool bNewNotifyRemovals)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewNotifyRemovals;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyRemovals, __InBuffer);
			}
		}

		public virtual void SetNotifyGlobalRemovals(bool bNewNotifyGlobalRemovals)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewNotifyGlobalRemovals;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyGlobalRemovals, __InBuffer);
			}
		}

		public virtual void SetNotifyGlobalCrumblings(bool bNewNotifyGlobalCrumblings, bool bGlobalNewCrumblingEventIncludesChildren)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bNewNotifyGlobalCrumblings;

				*(bool*)(__InBuffer + 1) = bGlobalNewCrumblingEventIncludesChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyGlobalCrumblings, __InBuffer);
			}
		}

		public virtual void SetNotifyGlobalCollision(bool bNewNotifyGlobalCollisions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewNotifyGlobalCollisions;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyGlobalCollision, __InBuffer);
			}
		}

		public virtual void SetNotifyGlobalBreaks(bool bNewNotifyGlobalBreaks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewNotifyGlobalBreaks;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyGlobalBreaks, __InBuffer);
			}
		}

		public virtual void SetNotifyCrumblings(bool bNewNotifyCrumblings, bool bNewCrumblingEventIncludesChildren = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bNewNotifyCrumblings;

				*(bool*)(__InBuffer + 1) = bNewCrumblingEventIncludesChildren;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyCrumblings, __InBuffer);
			}
		}

		public virtual void SetNotifyBreaks(bool bNewNotifyBreaks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewNotifyBreaks;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNotifyBreaks, __InBuffer);
			}
		}

		public virtual void SetLocalRestTransforms(TArray<FTransform> Transforms, bool bOnlyLeaves)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Transforms?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyLeaves;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLocalRestTransforms, __InBuffer);
			}
		}

		public virtual void SetEnableDamageFromCollision(bool bValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableDamageFromCollision, __InBuffer);
			}
		}

		public virtual void SetDamageThreshold(TArray<float> InDamageThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDamageThreshold?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDamageThreshold, __InBuffer);
			}
		}

		public virtual void SetAnchoredByTransformedBox(FBox Box, FTransform Transform, bool bAnchored, int MaxLevel = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Box?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAnchored;

				*(int*)(__InBuffer + 17) = MaxLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnchoredByTransformedBox, __InBuffer);
			}
		}

		public virtual void SetAnchoredByIndex(int Index, bool bAnchored)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = Index;

				*(bool*)(__InBuffer + 4) = bAnchored;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnchoredByIndex, __InBuffer);
			}
		}

		public virtual void SetAnchoredByBox(FBox WorldSpaceBox, bool bAnchored, int MaxLevel = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = WorldSpaceBox?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAnchored;

				*(int*)(__InBuffer + 9) = MaxLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnchoredByBox, __InBuffer);
			}
		}

		public virtual void SetAbandonedParticleCollisionProfileName(FName CollisionProfile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CollisionProfile?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAbandonedParticleCollisionProfileName, __InBuffer);
			}
		}

		public virtual void RemoveAllAnchors()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveAllAnchors);
			}
		}

		public virtual void ReceivePhysicsCollision(FChaosPhysicsCollisionInfo CollisionInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CollisionInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceivePhysicsCollision, __InBuffer);
			}
		}

		public virtual void OnRep_RepData()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_RepData);
			}
		}

		public virtual bool IsRootBroken()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRootBroken, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRootInitialTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootInitialTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual int GetRootIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRootIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRootCurrentTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootCurrentTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the cluster to get level from
		/// </param>
		/// <param name="Level">
		/// of the piece ( 0 for root level and positive for the rest )
		/// </param>
		public virtual void GetMassAndExtents(int ItemIndex, ref float OutMass, ref FBox OutExtents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = ItemIndex;

				*(float*)(__InBuffer + 4) = OutMass;

				*(nint*)(__InBuffer + 8) = OutExtents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMassAndExtents, __InBuffer, __OutBuffer);

				OutMass = *(float*)(__OutBuffer);

				OutExtents = *(FBox*)(__OutBuffer + 4);

			}
		}

		public virtual FBox GetLocalBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLocalBounds, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		public virtual TArray<FTransform> GetInitialLocalRestTransforms()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetInitialLocalRestTransforms, __ReturnBuffer);

				return *(TArray<FTransform>*)__ReturnBuffer;
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the cluster to get level from
		/// </param>
		/// <param name="Level">
		/// of the piece ( 0 for root level and positive for the rest ) 
		/// </param>
		public virtual int GetInitialLevel(int ItemIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ItemIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetInitialLevel, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FString GetDebugInfo()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDebugInfo, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual TArray<float> GetDamageThreshold()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDamageThreshold, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the cluster to crumble
		/// </param>
		public virtual void CrumbleCluster(int ItemIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ItemIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CrumbleCluster, __InBuffer);
			}
		}

		public virtual void CrumbleActiveClusters()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CrumbleActiveClusters);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Target">
		/// Type of field supported by the solver.
		/// </param>
		/// <param name="MetaData">
		/// Meta data used to assist in evaluation
		/// </param>
		/// <param name="Field">
		/// Base evaluation node for the field network.
		/// </param>
		public virtual void ApplyPhysicsField(bool Enabled, EGeometryCollectionPhysicsTypeEnum Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(bool*)(__InBuffer) = Enabled;

				*(byte*)(__InBuffer + 1) = (byte)Target;

				*(nint*)(__InBuffer + 2) = MetaData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 10) = Field?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyPhysicsField, __InBuffer);
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the piece to apply velocity on
		/// </param>
		/// <param name="LinearVelocity">
		/// linear velocity to apply
		/// </param>
		public virtual void ApplyLinearVelocity(int ItemIndex, FVector LinearVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ItemIndex;

				*(nint*)(__InBuffer + 4) = LinearVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyLinearVelocity, __InBuffer);
			}
		}

		/// <param name="Radius">
		/// Radial influence from the position
		/// </param>
		/// <param name="Position">
		/// The location of the command
		/// </param>
		public virtual void ApplyKinematicField(float Radius, FVector Position)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Radius;

				*(nint*)(__InBuffer + 4) = Position?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyKinematicField, __InBuffer);
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the piece to apply strain on
		/// </param>
		/// <param name="Location">
		/// world location of where to apply the strain
		/// </param>
		/// <param name="Radius">
		/// radius from the location point to apply the strain to ( using the center of mass of the pieces )
		/// </param>
		/// <param name="PropagationDepth">
		/// How many level of connection to follow to propagate the strain through
		/// </param>
		/// <param name="PropagationFactor">
		/// when using propagation, the factor to multiply the strain from one level to the other, allowing falloff effect
		/// </param>
		/// <param name="Strain">
		/// strain / damage to apply 
		/// </param>
		public virtual void ApplyInternalStrain(int ItemIndex, FVector Location, float Radius = 0.000000f, int PropagationDepth = 0, float PropagationFactor = 1.000000f, float Strain = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(int*)(__InBuffer) = ItemIndex;

				*(nint*)(__InBuffer + 4) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 12) = Radius;

				*(int*)(__InBuffer + 16) = PropagationDepth;

				*(float*)(__InBuffer + 20) = PropagationFactor;

				*(float*)(__InBuffer + 24) = Strain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyInternalStrain, __InBuffer);
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the piece to apply strain on
		/// </param>
		/// <param name="Location">
		/// world location of where to apply the strain
		/// </param>
		/// <param name="Radius">
		/// radius from the location point to apply the strain to ( using the center of mass of the pieces )
		/// </param>
		/// <param name="PropagationDepth">
		/// How many level of connection to follow to propagate the strain through
		/// </param>
		/// <param name="PropagationFactor">
		/// when using propagation, the factor to multiply the strain from one level to the other, allowing falloff effect
		/// </param>
		/// <param name="Strain">
		/// strain / damage to apply 
		/// </param>
		public virtual void ApplyExternalStrain(int ItemIndex, FVector Location, float Radius = 0.000000f, int PropagationDepth = 0, float PropagationFactor = 1.000000f, float Strain = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(int*)(__InBuffer) = ItemIndex;

				*(nint*)(__InBuffer + 4) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 12) = Radius;

				*(int*)(__InBuffer + 16) = PropagationDepth;

				*(float*)(__InBuffer + 20) = PropagationFactor;

				*(float*)(__InBuffer + 24) = Strain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyExternalStrain, __InBuffer);
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the cluster owning the breaking pieces to apply velocity on
		/// </param>
		/// <param name="LinearVelocity">
		/// linear velocity to apply
		/// </param>
		public virtual void ApplyBreakingLinearVelocity(int ItemIndex, FVector LinearVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ItemIndex;

				*(nint*)(__InBuffer + 4) = LinearVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyBreakingLinearVelocity, __InBuffer);
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the cluster owning the breaking pieces to apply velocity on
		/// </param>
		/// <param name="AngularVelocity">
		/// linear velocity to apply
		/// </param>
		public virtual void ApplyBreakingAngularVelocity(int ItemIndex, FVector AngularVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ItemIndex;

				*(nint*)(__InBuffer + 4) = AngularVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyBreakingAngularVelocity, __InBuffer);
			}
		}

		public virtual void ApplyAssetDefaults()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ApplyAssetDefaults);
			}
		}

		/// <param name="ItemIndex">
		/// item index ( from HitResult) of the piece to apply velocity on
		/// </param>
		/// <param name="AngularVelocity">
		/// linear velocity to apply
		/// </param>
		public virtual void ApplyAngularVelocity(int ItemIndex, FVector AngularVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = ItemIndex;

				*(nint*)(__InBuffer + 4) = AngularVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyAngularVelocity, __InBuffer);
			}
		}

		private static uint __ChaosSolverActor = 0;

		private static uint __RestCollection = 0;

		private static uint __InitializationFields = 0;

		private static uint __ObjectType = 0;

		private static uint __GravityGroupIndex = 0;

		private static uint __bForceMotionBlur = 0;

		private static uint __EnableClustering = 0;

		private static uint __ClusterGroupIndex = 0;

		private static uint __MaxClusterLevel = 0;

		private static uint __MaxSimulatedLevel = 0;

		private static uint __DamageModel = 0;

		private static uint __DamageThreshold = 0;

		private static uint __bUseSizeSpecificDamageThreshold = 0;

		private static uint __DamagePropagationData = 0;

		private static uint __bEnableDamageFromCollision = 0;

		private static uint __bAllowRemovalOnSleep = 0;

		private static uint __bAllowRemovalOnBreak = 0;

		private static uint __CollisionGroup = 0;

		private static uint __CollisionSampleFraction = 0;

		private static uint __InitialVelocityType = 0;

		private static uint __InitialLinearVelocity = 0;

		private static uint __InitialAngularVelocity = 0;

		private static uint __CacheParameters = 0;

		private static uint __RestTransforms = 0;

		private static uint __NotifyGeometryCollectionPhysicsStateChange = 0;

		private static uint __NotifyGeometryCollectionPhysicsLoadingStateChange = 0;

		private static uint __OnChaosBreakEvent = 0;

		private static uint __OnChaosRemovalEvent = 0;

		private static uint __OnChaosCrumblingEvent = 0;

		private static uint __DesiredCacheTime = 0;

		private static uint __CachePlayback = 0;

		private static uint __OnChaosPhysicsCollision = 0;

		private static uint __bNotifyBreaks = 0;

		private static uint __bNotifyCollisions = 0;

		private static uint __bNotifyTrailing = 0;

		private static uint __bNotifyRemovals = 0;

		private static uint __bNotifyCrumblings = 0;

		private static uint __bCrumblingEventIncludesChildren = 0;

		private static uint __bNotifyGlobalBreaks = 0;

		private static uint __bNotifyGlobalCollisions = 0;

		private static uint __bNotifyGlobalRemovals = 0;

		private static uint __bNotifyGlobalCrumblings = 0;

		private static uint __bGlobalCrumblingEventIncludesChildren = 0;

		private static uint __bStoreVelocities = 0;

		private static uint __bShowBoneColors = 0;

		private static uint __bUseRootProxyForNavigation = 0;

		private static uint __bUpdateNavigationInTick = 0;

		private static uint __bEnableRunTimeDataCollection = 0;

		private static uint __RunTimeDataCollectionGuid = 0;

		private static uint __bOverrideCustomRenderer = 0;

		private static uint __CustomRendererType = 0;

		private static uint __CustomRenderer = 0;

		private static uint __bEnableReplication = 0;

		private static uint __bEnableAbandonAfterLevel = 0;

		private static uint __AbandonedCollisionProfileName = 0;

		private static uint __CollisionProfilePerLevel = 0;

		private static uint __ReplicationAbandonAfterLevel = 0;

		private static uint __ReplicationMaxPositionAndVelocityCorrectionLevel = 0;

		private static uint __RepData = 0;

		private static uint __SelectedBones = 0;

		private static uint __HighlightedBones = 0;

		private static uint __DummyBodySetup = 0;

		private static uint __EditorActor = 0;

		private static uint __EventDispatcher = 0;

		private static uint __EmbeddedGeometryComponents = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetRestCollection = 0;

		private static uint __SetPerParticleCollisionProfileName = 0;

		private static uint __SetPerLevelCollisionProfileNames = 0;

		private static uint __SetNotifyRemovals = 0;

		private static uint __SetNotifyGlobalRemovals = 0;

		private static uint __SetNotifyGlobalCrumblings = 0;

		private static uint __SetNotifyGlobalCollision = 0;

		private static uint __SetNotifyGlobalBreaks = 0;

		private static uint __SetNotifyCrumblings = 0;

		private static uint __SetNotifyBreaks = 0;

		private static uint __SetLocalRestTransforms = 0;

		private static uint __SetEnableDamageFromCollision = 0;

		private static uint __SetDamageThreshold = 0;

		private static uint __SetAnchoredByTransformedBox = 0;

		private static uint __SetAnchoredByIndex = 0;

		private static uint __SetAnchoredByBox = 0;

		private static uint __SetAbandonedParticleCollisionProfileName = 0;

		private static uint __RemoveAllAnchors = 0;

		private static uint __ReceivePhysicsCollision = 0;

		private static uint __OnRep_RepData = 0;

		private static uint __IsRootBroken = 0;

		private static uint __GetRootInitialTransform = 0;

		private static uint __GetRootIndex = 0;

		private static uint __GetRootCurrentTransform = 0;

		private static uint __GetMassAndExtents = 0;

		private static uint __GetLocalBounds = 0;

		private static uint __GetInitialLocalRestTransforms = 0;

		private static uint __GetInitialLevel = 0;

		private static uint __GetDebugInfo = 0;

		private static uint __GetDamageThreshold = 0;

		private static uint __CrumbleCluster = 0;

		private static uint __CrumbleActiveClusters = 0;

		private static uint __ApplyPhysicsField = 0;

		private static uint __ApplyLinearVelocity = 0;

		private static uint __ApplyKinematicField = 0;

		private static uint __ApplyInternalStrain = 0;

		private static uint __ApplyExternalStrain = 0;

		private static uint __ApplyBreakingLinearVelocity = 0;

		private static uint __ApplyBreakingAngularVelocity = 0;

		private static uint __ApplyAssetDefaults = 0;

		private static uint __ApplyAngularVelocity = 0;
	}
}