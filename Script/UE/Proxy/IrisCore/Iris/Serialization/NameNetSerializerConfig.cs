using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NameNetSerializerConfig")]
	public partial class FNameNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.NameNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNameNetSerializerConfig()
		{
		}

		public static bool operator ==(FNameNetSerializerConfig A, FNameNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNameNetSerializerConfig A, FNameNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNameNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}