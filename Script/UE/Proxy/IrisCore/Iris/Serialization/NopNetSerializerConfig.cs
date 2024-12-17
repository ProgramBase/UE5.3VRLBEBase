using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NopNetSerializerConfig")]
	public partial class FNopNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.NopNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNopNetSerializerConfig()
		{
		}

		public static bool operator ==(FNopNetSerializerConfig A, FNopNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNopNetSerializerConfig A, FNopNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNopNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}