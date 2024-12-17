using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.RepMovementNetSerializerConfig")]
	public partial class FRepMovementNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RepMovementNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRepMovementNetSerializerConfig()
		{
		}

		public static bool operator ==(FRepMovementNetSerializerConfig A, FRepMovementNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRepMovementNetSerializerConfig A, FRepMovementNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRepMovementNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}