using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusterUnionReplicatedData")]
	public partial class FClusterUnionReplicatedData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ClusterUnionReplicatedData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClusterUnionReplicatedData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClusterUnionReplicatedData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClusterUnionReplicatedData A, FClusterUnionReplicatedData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClusterUnionReplicatedData A, FClusterUnionReplicatedData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClusterUnionReplicatedData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte ObjectState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectState, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectState, __InBuffer);
				}
			}
		}

		public bool bIsAnchored
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsAnchored, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsAnchored, __InBuffer);
				}
			}
		}

		private static uint __ObjectState = 0;

		private static uint __bIsAnchored = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}