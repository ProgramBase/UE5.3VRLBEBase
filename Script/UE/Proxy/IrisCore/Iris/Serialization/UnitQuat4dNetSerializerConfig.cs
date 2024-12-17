using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.UnitQuat4dNetSerializerConfig")]
	public partial class FUnitQuat4dNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.UnitQuat4dNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUnitQuat4dNetSerializerConfig()
		{
		}

		public static bool operator ==(FUnitQuat4dNetSerializerConfig A, FUnitQuat4dNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUnitQuat4dNetSerializerConfig A, FUnitQuat4dNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUnitQuat4dNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}