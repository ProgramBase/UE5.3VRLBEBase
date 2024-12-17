using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMTernaryOp")]
	public partial class FRigVMTernaryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMTernaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMTernaryOp()
		{
		}

		public static bool operator ==(FRigVMTernaryOp A, FRigVMTernaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMTernaryOp A, FRigVMTernaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMTernaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}