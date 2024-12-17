using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.DoubleNetSerializerConfig")]
	public partial class FDoubleNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.DoubleNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDoubleNetSerializerConfig()
		{
		}

		public static bool operator ==(FDoubleNetSerializerConfig A, FDoubleNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDoubleNetSerializerConfig A, FDoubleNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDoubleNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}