using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.RotatorAsByteNetSerializerConfig")]
	public partial class FRotatorAsByteNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.RotatorAsByteNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRotatorAsByteNetSerializerConfig()
		{
		}

		public static bool operator ==(FRotatorAsByteNetSerializerConfig A, FRotatorAsByteNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRotatorAsByteNetSerializerConfig A, FRotatorAsByteNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRotatorAsByteNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}