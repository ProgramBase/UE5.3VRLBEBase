using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.VectorNetQuantize100NetSerializerConfig")]
	public partial class FVectorNetQuantize100NetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.VectorNetQuantize100NetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVectorNetQuantize100NetSerializerConfig()
		{
		}

		public static bool operator ==(FVectorNetQuantize100NetSerializerConfig A, FVectorNetQuantize100NetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVectorNetQuantize100NetSerializerConfig A, FVectorNetQuantize100NetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVectorNetQuantize100NetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}