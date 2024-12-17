using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DebugBaseMutable")]
	public partial class FRigUnit_DebugBaseMutable : FRigUnitMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DebugBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DebugBaseMutable()
		{
		}

		public static bool operator ==(FRigUnit_DebugBaseMutable A, FRigUnit_DebugBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DebugBaseMutable A, FRigUnit_DebugBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DebugBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}