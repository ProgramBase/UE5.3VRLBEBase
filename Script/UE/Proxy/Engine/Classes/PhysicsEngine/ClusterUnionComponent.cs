using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusterUnionComponent")]
	public partial class UClusterUnionComponent : UPrimitiveComponent, IStaticClass
	{
		public FOnClusterUnionAddedComponent OnComponentAddedEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentAddedEvent, __ReturnBuffer);

					return *(FOnClusterUnionAddedComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentAddedEvent, __InBuffer);
				}
			}
		}

		public FOnClusterUnionRemovedComponent OnComponentRemovedEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentRemovedEvent, __ReturnBuffer);

					return *(FOnClusterUnionRemovedComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentRemovedEvent, __InBuffer);
				}
			}
		}

		public FOnClusterUnionBoundsChanged OnComponentBoundsChangedEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentBoundsChangedEvent, __ReturnBuffer);

					return *(FOnClusterUnionBoundsChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnComponentBoundsChangedEvent, __InBuffer);
				}
			}
		}

		public TArray<FComponentReference> ClusteredComponentsReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClusteredComponentsReferences, __ReturnBuffer);

					return *(TArray<FComponentReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClusteredComponentsReferences, __InBuffer);
				}
			}
		}

		public TMap<int, FClusterUnionParticleCandidateData> UniqueIdxToComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UniqueIdxToComponent, __ReturnBuffer);

					return *(TMap<int, FClusterUnionParticleCandidateData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UniqueIdxToComponent, __InBuffer);
				}
			}
		}

		public FClusterUnionReplicatedData ReplicatedRigidState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedRigidState, __ReturnBuffer);

					return *(FClusterUnionReplicatedData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedRigidState, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ClusterUnionComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetIsAnchored(bool bIsAnchored)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsAnchored;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsAnchored, __InBuffer);
			}
		}

		public virtual void RemoveComponentFromCluster(UPrimitiveComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveComponentFromCluster, __InBuffer);
			}
		}

		public virtual void OnRep_RigidState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_RigidState);
			}
		}

		public virtual bool IsComponentAdded(UPrimitiveComponent Component)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsComponentAdded, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsAuthority()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAuthority, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void HandleComponentPhysicsStateChangePostAddIntoClusterUnion(UPrimitiveComponent ChangedComponent, EComponentPhysicsStateChange StateChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ChangedComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)StateChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __HandleComponentPhysicsStateChangePostAddIntoClusterUnion, __InBuffer);
			}
		}

		public virtual void HandleComponentPhysicsStateChange(UPrimitiveComponent ChangedComponent, EComponentPhysicsStateChange StateChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ChangedComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)StateChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __HandleComponentPhysicsStateChange, __InBuffer);
			}
		}

		public virtual TArray<UPrimitiveComponent> GetPrimitiveComponents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPrimitiveComponents, __ReturnBuffer);

				return *(TArray<UPrimitiveComponent>*)__ReturnBuffer;
			}
		}

		public virtual TArray<AActor> GetActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public virtual void ForceSetChildToParent(UPrimitiveComponent InComponent, TArray<int> BoneIds, TArray<FTransform> ChildToParent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneIds?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ChildToParent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ForceSetChildToParent, __InBuffer);
			}
		}

		public virtual void AddComponentToCluster(UPrimitiveComponent InComponent, TArray<int> BoneIds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneIds?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddComponentToCluster, __InBuffer);
			}
		}

		private static uint __OnComponentAddedEvent = 0;

		private static uint __OnComponentRemovedEvent = 0;

		private static uint __OnComponentBoundsChangedEvent = 0;

		private static uint __ClusteredComponentsReferences = 0;

		private static uint __UniqueIdxToComponent = 0;

		private static uint __ReplicatedRigidState = 0;

		private static uint __SetIsAnchored = 0;

		private static uint __RemoveComponentFromCluster = 0;

		private static uint __OnRep_RigidState = 0;

		private static uint __IsComponentAdded = 0;

		private static uint __IsAuthority = 0;

		private static uint __HandleComponentPhysicsStateChangePostAddIntoClusterUnion = 0;

		private static uint __HandleComponentPhysicsStateChange = 0;

		private static uint __GetPrimitiveComponents = 0;

		private static uint __GetActors = 0;

		private static uint __ForceSetChildToParent = 0;

		private static uint __AddComponentToCluster = 0;
	}
}