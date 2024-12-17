using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.RotatorAsShortNetSerializerConfig")]
	public partial class FRotatorAsShortNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.RotatorAsShortNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRotatorAsShortNetSerializerConfig()
		{
		}

		public static bool operator ==(FRotatorAsShortNetSerializerConfig A, FRotatorAsShortNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRotatorAsShortNetSerializerConfig A, FRotatorAsShortNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRotatorAsShortNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}