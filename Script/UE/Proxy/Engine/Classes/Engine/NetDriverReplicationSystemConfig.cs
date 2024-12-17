using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetDriverReplicationSystemConfig")]
	public partial class FNetDriverReplicationSystemConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NetDriverReplicationSystemConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNetDriverReplicationSystemConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNetDriverReplicationSystemConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNetDriverReplicationSystemConfig A, FNetDriverReplicationSystemConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNetDriverReplicationSystemConfig A, FNetDriverReplicationSystemConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNetDriverReplicationSystemConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint MaxReplicatedObjectCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxReplicatedObjectCount, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxReplicatedObjectCount, __InBuffer);
				}
			}
		}

		public uint MaxDeltaCompressedObjectCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxDeltaCompressedObjectCount, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxDeltaCompressedObjectCount, __InBuffer);
				}
			}
		}

		public uint MaxNetObjectGroupCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxNetObjectGroupCount, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxNetObjectGroupCount, __InBuffer);
				}
			}
		}

		private static uint __MaxReplicatedObjectCount = 0;

		private static uint __MaxDeltaCompressedObjectCount = 0;

		private static uint __MaxNetObjectGroupCount = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}