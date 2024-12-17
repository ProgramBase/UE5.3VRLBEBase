using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_DebugBase")]
	public partial class FRigUnit_DebugBase : FRigUnit, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_DebugBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_DebugBase()
		{
		}

		public static bool operator ==(FRigUnit_DebugBase A, FRigUnit_DebugBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_DebugBase A, FRigUnit_DebugBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_DebugBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}