using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ObjectNetSerializerConfig")]
	public partial class FObjectNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.ObjectNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectNetSerializerConfig()
		{
		}

		public static bool operator ==(FObjectNetSerializerConfig A, FObjectNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectNetSerializerConfig A, FObjectNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}