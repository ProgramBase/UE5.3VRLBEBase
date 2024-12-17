using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMJumpToBranchOp")]
	public partial class FRigVMJumpToBranchOp : FRigVMUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMJumpToBranchOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMJumpToBranchOp()
		{
		}

		public static bool operator ==(FRigVMJumpToBranchOp A, FRigVMJumpToBranchOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMJumpToBranchOp A, FRigVMJumpToBranchOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMJumpToBranchOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}