using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PackedInt64NetSerializerConfig")]
	public partial class FPackedInt64NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.PackedInt64NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackedInt64NetSerializerConfig()
		{
		}

		public static bool operator ==(FPackedInt64NetSerializerConfig A, FPackedInt64NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackedInt64NetSerializerConfig A, FPackedInt64NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackedInt64NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}