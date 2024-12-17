using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.UniqueNetIdReplNetSerializerConfig")]
	public partial class FUniqueNetIdReplNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.UniqueNetIdReplNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUniqueNetIdReplNetSerializerConfig()
		{
		}

		public static bool operator ==(FUniqueNetIdReplNetSerializerConfig A, FUniqueNetIdReplNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUniqueNetIdReplNetSerializerConfig A, FUniqueNetIdReplNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUniqueNetIdReplNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}