using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.VectorNetQuantizeNormalNetSerializerConfig")]
	public partial class FVectorNetQuantizeNormalNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.VectorNetQuantizeNormalNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorNetQuantizeNormalNetSerializerConfig()
		{
		}

		public static bool operator ==(FVectorNetQuantizeNormalNetSerializerConfig A, FVectorNetQuantizeNormalNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorNetQuantizeNormalNetSerializerConfig A, FVectorNetQuantizeNormalNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorNetQuantizeNormalNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}