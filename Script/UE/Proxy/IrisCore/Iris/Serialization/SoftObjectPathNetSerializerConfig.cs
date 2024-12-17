using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SoftObjectPathNetSerializerConfig")]
	public partial class FSoftObjectPathNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.SoftObjectPathNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftObjectPathNetSerializerConfig()
		{
		}

		public static bool operator ==(FSoftObjectPathNetSerializerConfig A, FSoftObjectPathNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftObjectPathNetSerializerConfig A, FSoftObjectPathNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftObjectPathNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}