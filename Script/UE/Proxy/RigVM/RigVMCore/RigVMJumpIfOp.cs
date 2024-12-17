using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMJumpIfOp")]
	public partial class FRigVMJumpIfOp : FRigVMUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMJumpIfOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMJumpIfOp()
		{
		}

		public static bool operator ==(FRigVMJumpIfOp A, FRigVMJumpIfOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMJumpIfOp A, FRigVMJumpIfOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMJumpIfOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}