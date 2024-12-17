using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusteredComponentData")]
	public partial class FClusteredComponentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ClusteredComponentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClusteredComponentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClusteredComponentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClusteredComponentData A, FClusteredComponentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClusteredComponentData A, FClusteredComponentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClusteredComponentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UClusterUnionReplicatedProxyComponent> ReplicatedProxyComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplicatedProxyComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<UClusterUnionReplicatedProxyComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplicatedProxyComponent, __InBuffer);
				}
			}
		}

		public bool bWasReplicating
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bWasReplicating, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bWasReplicating, __InBuffer);
				}
			}
		}

		public bool bPendingDeletion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPendingDeletion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPendingDeletion, __InBuffer);
				}
			}
		}

		private static uint __ReplicatedProxyComponent = 0;

		private static uint __bWasReplicating = 0;

		private static uint __bPendingDeletion = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}