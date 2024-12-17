using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.FloatNetSerializerConfig")]
	public partial class FFloatNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.FloatNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatNetSerializerConfig()
		{
		}

		public static bool operator ==(FFloatNetSerializerConfig A, FFloatNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatNetSerializerConfig A, FFloatNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}