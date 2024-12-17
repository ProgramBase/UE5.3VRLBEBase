using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PackedUint32NetSerializerConfig")]
	public partial class FPackedUint32NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.PackedUint32NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackedUint32NetSerializerConfig()
		{
		}

		public static bool operator ==(FPackedUint32NetSerializerConfig A, FPackedUint32NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackedUint32NetSerializerConfig A, FPackedUint32NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackedUint32NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}