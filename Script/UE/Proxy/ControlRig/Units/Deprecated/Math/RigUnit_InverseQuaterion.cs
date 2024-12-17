using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_InverseQuaterion")]
	public partial class FRigUnit_InverseQuaterion : FRigUnit_UnaryQuaternionOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_InverseQuaterion");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_InverseQuaterion()
		{
		}

		public static bool operator ==(FRigUnit_InverseQuaterion A, FRigUnit_InverseQuaterion B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_InverseQuaterion A, FRigUnit_InverseQuaterion B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_InverseQuaterion;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}