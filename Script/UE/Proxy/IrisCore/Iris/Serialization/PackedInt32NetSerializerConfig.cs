using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PackedInt32NetSerializerConfig")]
	public partial class FPackedInt32NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.PackedInt32NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackedInt32NetSerializerConfig()
		{
		}

		public static bool operator ==(FPackedInt32NetSerializerConfig A, FPackedInt32NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackedInt32NetSerializerConfig A, FPackedInt32NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackedInt32NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}