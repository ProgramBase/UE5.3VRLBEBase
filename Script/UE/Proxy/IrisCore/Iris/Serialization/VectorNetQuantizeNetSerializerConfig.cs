using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.VectorNetQuantizeNetSerializerConfig")]
	public partial class FVectorNetQuantizeNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.VectorNetQuantizeNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorNetQuantizeNetSerializerConfig()
		{
		}

		public static bool operator ==(FVectorNetQuantizeNetSerializerConfig A, FVectorNetQuantizeNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorNetQuantizeNetSerializerConfig A, FVectorNetQuantizeNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorNetQuantizeNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}