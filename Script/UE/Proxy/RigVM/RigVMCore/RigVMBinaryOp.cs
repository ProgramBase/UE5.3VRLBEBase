using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMBinaryOp")]
	public partial class FRigVMBinaryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMBinaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMBinaryOp()
		{
		}

		public static bool operator ==(FRigVMBinaryOp A, FRigVMBinaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMBinaryOp A, FRigVMBinaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMBinaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}