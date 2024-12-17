using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMInvokeEntryOp")]
	public partial class FRigVMInvokeEntryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMInvokeEntryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMInvokeEntryOp()
		{
		}

		public static bool operator ==(FRigVMInvokeEntryOp A, FRigVMInvokeEntryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMInvokeEntryOp A, FRigVMInvokeEntryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMInvokeEntryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}