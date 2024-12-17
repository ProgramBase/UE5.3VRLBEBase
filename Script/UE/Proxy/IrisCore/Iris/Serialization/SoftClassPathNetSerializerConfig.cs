using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SoftClassPathNetSerializerConfig")]
	public partial class FSoftClassPathNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.SoftClassPathNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftClassPathNetSerializerConfig()
		{
		}

		public static bool operator ==(FSoftClassPathNetSerializerConfig A, FSoftClassPathNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftClassPathNetSerializerConfig A, FSoftClassPathNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftClassPathNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}