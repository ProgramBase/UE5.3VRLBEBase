using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InstancedStaticMeshComponentInstanceData")]
	public partial class FInstancedStaticMeshComponentInstanceData : FSceneComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InstancedStaticMeshComponentInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInstancedStaticMeshComponentInstanceData()
		{
		}

		public static bool operator ==(FInstancedStaticMeshComponentInstanceData A, FInstancedStaticMeshComponentInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInstancedStaticMeshComponentInstanceData A, FInstancedStaticMeshComponentInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInstancedStaticMeshComponentInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UStaticMesh StaticMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticMesh, __InBuffer);
				}
			}
		}

		public FInstancedStaticMeshLightMapInstanceData CachedStaticLighting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedStaticLighting, __ReturnBuffer);

					return *(FInstancedStaticMeshLightMapInstanceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedStaticLighting, __InBuffer);
				}
			}
		}

		public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMData, __ReturnBuffer);

					return *(TArray<FInstancedStaticMeshInstanceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMData, __InBuffer);
				}
			}
		}

		public TArray<float> PerInstanceSMCustomData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMCustomData, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMCustomData, __InBuffer);
				}
			}
		}

		public int InstancingRandomSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstancingRandomSeed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstancingRandomSeed, __InBuffer);
				}
			}
		}

		public TArray<FInstancedStaticMeshRandomSeed> AdditionalRandomSeeds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalRandomSeeds, __ReturnBuffer);

					return *(TArray<FInstancedStaticMeshRandomSeed>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalRandomSeeds, __InBuffer);
				}
			}
		}

		public bool bHasPerInstanceHitProxies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasPerInstanceHitProxies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasPerInstanceHitProxies, __InBuffer);
				}
			}
		}

		private static uint __StaticMesh = 0;

		private static uint __CachedStaticLighting = 0;

		private static uint __PerInstanceSMData = 0;

		private static uint __PerInstanceSMCustomData = 0;

		private static uint __InstancingRandomSeed = 0;

		private static uint __AdditionalRandomSeeds = 0;

		private static uint __bHasPerInstanceHitProxies = 0;

	}
}