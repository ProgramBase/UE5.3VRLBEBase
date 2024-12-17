using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusterUnionPendingAddData")]
	public partial class FClusterUnionPendingAddData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ClusterUnionPendingAddData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClusterUnionPendingAddData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClusterUnionPendingAddData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClusterUnionPendingAddData A, FClusterUnionPendingAddData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClusterUnionPendingAddData A, FClusterUnionPendingAddData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClusterUnionPendingAddData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> BoneIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneIds, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneIds, __InBuffer);
				}
			}
		}

		public TArray<FExternalSpatialAccelerationPayload> AccelerationPayloads
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AccelerationPayloads, __ReturnBuffer);

					return *(TArray<FExternalSpatialAccelerationPayload>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AccelerationPayloads, __InBuffer);
				}
			}
		}

		private static uint __BoneIds = 0;

		private static uint __AccelerationPayloads = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}