using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PolymorphicArrayStructNetSerializerConfig")]
	public partial class FPolymorphicArrayStructNetSerializerConfig : FPolymorphicStructNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.PolymorphicArrayStructNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPolymorphicArrayStructNetSerializerConfig()
		{
		}

		public static bool operator ==(FPolymorphicArrayStructNetSerializerConfig A, FPolymorphicArrayStructNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPolymorphicArrayStructNetSerializerConfig A, FPolymorphicArrayStructNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPolymorphicArrayStructNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}