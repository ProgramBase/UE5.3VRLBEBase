using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.RotatorNetSerializerConfig")]
	public partial class FRotatorNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.RotatorNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRotatorNetSerializerConfig()
		{
		}

		public static bool operator ==(FRotatorNetSerializerConfig A, FRotatorNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRotatorNetSerializerConfig A, FRotatorNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRotatorNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}