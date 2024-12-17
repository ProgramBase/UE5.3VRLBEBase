using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigUnit_MultiplyQuaternion")]
	public partial class FRigUnit_MultiplyQuaternion : FRigUnit_BinaryQuaternionOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigUnit_MultiplyQuaternion");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigUnit_MultiplyQuaternion()
		{
		}

		public static bool operator ==(FRigUnit_MultiplyQuaternion A, FRigUnit_MultiplyQuaternion B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigUnit_MultiplyQuaternion A, FRigUnit_MultiplyQuaternion B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigUnit_MultiplyQuaternion;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}