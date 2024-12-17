using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.StructNetSerializerConfig")]
	public partial class FStructNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.StructNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStructNetSerializerConfig()
		{
		}

		public static bool operator ==(FStructNetSerializerConfig A, FStructNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStructNetSerializerConfig A, FStructNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStructNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}