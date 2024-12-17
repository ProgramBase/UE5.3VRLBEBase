using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PackedUint64NetSerializerConfig")]
	public partial class FPackedUint64NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.PackedUint64NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackedUint64NetSerializerConfig()
		{
		}

		public static bool operator ==(FPackedUint64NetSerializerConfig A, FPackedUint64NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackedUint64NetSerializerConfig A, FPackedUint64NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackedUint64NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}