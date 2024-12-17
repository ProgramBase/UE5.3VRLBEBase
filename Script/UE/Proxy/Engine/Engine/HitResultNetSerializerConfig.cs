using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.HitResultNetSerializerConfig")]
	public partial class FHitResultNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.HitResultNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHitResultNetSerializerConfig()
		{
		}

		public static bool operator ==(FHitResultNetSerializerConfig A, FHitResultNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHitResultNetSerializerConfig A, FHitResultNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHitResultNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}