using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.DateTimeNetSerializerConfig")]
	public partial class FDateTimeNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.DateTimeNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDateTimeNetSerializerConfig()
		{
		}

		public static bool operator ==(FDateTimeNetSerializerConfig A, FDateTimeNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDateTimeNetSerializerConfig A, FDateTimeNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDateTimeNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}