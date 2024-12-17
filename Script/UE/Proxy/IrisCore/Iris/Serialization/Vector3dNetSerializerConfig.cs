using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.Vector3dNetSerializerConfig")]
	public partial class FVector3dNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.Vector3dNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVector3dNetSerializerConfig()
		{
		}

		public static bool operator ==(FVector3dNetSerializerConfig A, FVector3dNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVector3dNetSerializerConfig A, FVector3dNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVector3dNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}