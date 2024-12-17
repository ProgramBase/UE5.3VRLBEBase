using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PolymorphicStructNetSerializerConfig")]
	public partial class FPolymorphicStructNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.PolymorphicStructNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPolymorphicStructNetSerializerConfig()
		{
		}

		public static bool operator ==(FPolymorphicStructNetSerializerConfig A, FPolymorphicStructNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPolymorphicStructNetSerializerConfig A, FPolymorphicStructNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPolymorphicStructNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}