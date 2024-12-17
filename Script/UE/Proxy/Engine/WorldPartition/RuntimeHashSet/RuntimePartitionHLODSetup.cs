using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimePartitionHLODSetup")]
	public partial class FRuntimePartitionHLODSetup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RuntimePartitionHLODSetup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRuntimePartitionHLODSetup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRuntimePartitionHLODSetup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRuntimePartitionHLODSetup A, FRuntimePartitionHLODSetup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRuntimePartitionHLODSetup A, FRuntimePartitionHLODSetup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRuntimePartitionHLODSetup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UHLODLayer HLODLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HLODLayer, __ReturnBuffer);

					return *(UHLODLayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HLODLayer, __InBuffer);
				}
			}
		}

		public URuntimePartition PartitionLayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PartitionLayer, __ReturnBuffer);

					return *(URuntimePartition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PartitionLayer, __InBuffer);
				}
			}
		}

		private static uint __HLODLayer = 0;

		private static uint __PartitionLayer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}