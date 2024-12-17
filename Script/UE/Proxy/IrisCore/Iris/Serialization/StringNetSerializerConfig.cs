using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.StringNetSerializerConfig")]
	public partial class FStringNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.StringNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStringNetSerializerConfig()
		{
		}

		public static bool operator ==(FStringNetSerializerConfig A, FStringNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStringNetSerializerConfig A, FStringNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStringNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}