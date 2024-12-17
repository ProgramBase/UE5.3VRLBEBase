using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.VectorNetSerializerConfig")]
	public partial class FVectorNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.VectorNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorNetSerializerConfig()
		{
		}

		public static bool operator ==(FVectorNetSerializerConfig A, FVectorNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorNetSerializerConfig A, FVectorNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}