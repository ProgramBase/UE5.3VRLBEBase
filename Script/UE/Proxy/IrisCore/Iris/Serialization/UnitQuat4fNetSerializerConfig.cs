using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.UnitQuat4fNetSerializerConfig")]
	public partial class FUnitQuat4fNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.UnitQuat4fNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUnitQuat4fNetSerializerConfig()
		{
		}

		public static bool operator ==(FUnitQuat4fNetSerializerConfig A, FUnitQuat4fNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUnitQuat4fNetSerializerConfig A, FUnitQuat4fNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUnitQuat4fNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}