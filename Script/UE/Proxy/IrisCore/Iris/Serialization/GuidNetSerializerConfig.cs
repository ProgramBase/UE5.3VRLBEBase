using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.GuidNetSerializerConfig")]
	public partial class FGuidNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.GuidNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGuidNetSerializerConfig()
		{
		}

		public static bool operator ==(FGuidNetSerializerConfig A, FGuidNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGuidNetSerializerConfig A, FGuidNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGuidNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}