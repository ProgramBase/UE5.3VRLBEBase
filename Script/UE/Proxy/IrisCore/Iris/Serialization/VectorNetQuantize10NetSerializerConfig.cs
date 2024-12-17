using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.VectorNetQuantize10NetSerializerConfig")]
	public partial class FVectorNetQuantize10NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.VectorNetQuantize10NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorNetQuantize10NetSerializerConfig()
		{
		}

		public static bool operator ==(FVectorNetQuantize10NetSerializerConfig A, FVectorNetQuantize10NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorNetQuantize10NetSerializerConfig A, FVectorNetQuantize10NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorNetQuantize10NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}