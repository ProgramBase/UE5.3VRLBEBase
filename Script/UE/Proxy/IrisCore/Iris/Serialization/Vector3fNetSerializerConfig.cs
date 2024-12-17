using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.Vector3fNetSerializerConfig")]
	public partial class FVector3fNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.Vector3fNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector3fNetSerializerConfig()
		{
		}

		public static bool operator ==(FVector3fNetSerializerConfig A, FVector3fNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector3fNetSerializerConfig A, FVector3fNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector3fNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}