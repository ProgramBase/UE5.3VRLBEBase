using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMJumpOp")]
	public partial class FRigVMJumpOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMJumpOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMJumpOp()
		{
		}

		public static bool operator ==(FRigVMJumpOp A, FRigVMJumpOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMJumpOp A, FRigVMJumpOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMJumpOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}