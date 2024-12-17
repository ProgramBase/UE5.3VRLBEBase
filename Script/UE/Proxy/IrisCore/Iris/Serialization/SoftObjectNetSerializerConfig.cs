using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SoftObjectNetSerializerConfig")]
	public partial class FSoftObjectNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.SoftObjectNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftObjectNetSerializerConfig()
		{
		}

		public static bool operator ==(FSoftObjectNetSerializerConfig A, FSoftObjectNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftObjectNetSerializerConfig A, FSoftObjectNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftObjectNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}