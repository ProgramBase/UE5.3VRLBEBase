using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusterUnionReplicatedProxyComponent")]
	public partial class UClusterUnionReplicatedProxyComponent : UActorComponent, IStaticClass
	{
		public TWeakObjectPtr<UClusterUnionComponent> ParentClusterUnion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClusterUnion, __ReturnBuffer);

					return *(TWeakObjectPtr<UClusterUnionComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClusterUnion, __InBuffer);
				}
			}
		}

		public bool bNetUpdateParentClusterUnion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateParentClusterUnion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateParentClusterUnion, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UPrimitiveComponent> ChildClusteredComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChildClusteredComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<UPrimitiveComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChildClusteredComponent, __InBuffer);
				}
			}
		}

		public bool bNetUpdateChildClusteredComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateChildClusteredComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateChildClusteredComponent, __InBuffer);
				}
			}
		}

		public TArray<int> ParticleBoneIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleBoneIds, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleBoneIds, __InBuffer);
				}
			}
		}

		public bool bNetUpdateParticleBoneIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateParticleBoneIds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateParticleBoneIds, __InBuffer);
				}
			}
		}

		public TArray<FTransform> ParticleChildToParents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleChildToParents, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParticleChildToParents, __InBuffer);
				}
			}
		}

		public bool bNetUpdateParticleChildToParents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateParticleChildToParents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNetUpdateParticleChildToParents, __InBuffer);
				}
			}
		}

		public bool bIsPendingDeletion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPendingDeletion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPendingDeletion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ClusterUnionReplicatedProxyComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetParticleChildToParent(int BoneId, FTransform ChildToParent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = BoneId;

				*(nint*)(__InBuffer + 4) = ChildToParent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParticleChildToParent, __InBuffer);
			}
		}

		public virtual void SetParticleBoneIds(TArray<int> InIds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InIds?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParticleBoneIds, __InBuffer);
			}
		}

		public virtual void SetParentClusterUnion(UClusterUnionComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParentClusterUnion, __InBuffer);
			}
		}

		public virtual void SetChildClusteredComponent(UPrimitiveComponent InComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InComponent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetChildClusteredComponent, __InBuffer);
			}
		}

		public virtual void OnRep_ParticleChildToParents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ParticleChildToParents);
			}
		}

		public virtual void OnRep_ParticleBoneIds()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ParticleBoneIds);
			}
		}

		public virtual void OnRep_ParentClusterUnion()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ParentClusterUnion);
			}
		}

		public virtual void OnRep_ChildClusteredComponent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ChildClusteredComponent);
			}
		}

		public virtual void MarkPendingDeletion()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MarkPendingDeletion);
			}
		}

		public virtual bool IsPendingDeletion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPendingDeletion, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UClusterUnionComponent GetParentClusterUnionComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParentClusterUnionComponent, __ReturnBuffer);

				return *(UClusterUnionComponent*)__ReturnBuffer;
			}
		}

		private static uint __ParentClusterUnion = 0;

		private static uint __bNetUpdateParentClusterUnion = 0;

		private static uint __ChildClusteredComponent = 0;

		private static uint __bNetUpdateChildClusteredComponent = 0;

		private static uint __ParticleBoneIds = 0;

		private static uint __bNetUpdateParticleBoneIds = 0;

		private static uint __ParticleChildToParents = 0;

		private static uint __bNetUpdateParticleChildToParents = 0;

		private static uint __bIsPendingDeletion = 0;

		private static uint __SetParticleChildToParent = 0;

		private static uint __SetParticleBoneIds = 0;

		private static uint __SetParentClusterUnion = 0;

		private static uint __SetChildClusteredComponent = 0;

		private static uint __OnRep_ParticleChildToParents = 0;

		private static uint __OnRep_ParticleBoneIds = 0;

		private static uint __OnRep_ParentClusterUnion = 0;

		private static uint __OnRep_ChildClusteredComponent = 0;

		private static uint __MarkPendingDeletion = 0;

		private static uint __IsPendingDeletion = 0;

		private static uint __GetParentClusterUnionComponent = 0;
	}
}