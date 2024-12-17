using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMExecuteOp")]
	public partial class FRigVMExecuteOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMExecuteOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMExecuteOp()
		{
		}

		public static bool operator ==(FRigVMExecuteOp A, FRigVMExecuteOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMExecuteOp A, FRigVMExecuteOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMExecuteOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}