using Script.CoreUObject;
using Script.Library;
using Script.IrisCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.RootMotionSourceGroupNetSerializerConfig")]
	public partial class FRootMotionSourceGroupNetSerializerConfig : FPolymorphicArrayStructNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RootMotionSourceGroupNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRootMotionSourceGroupNetSerializerConfig()
		{
		}

		public static bool operator ==(FRootMotionSourceGroupNetSerializerConfig A, FRootMotionSourceGroupNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRootMotionSourceGroupNetSerializerConfig A, FRootMotionSourceGroupNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRootMotionSourceGroupNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}