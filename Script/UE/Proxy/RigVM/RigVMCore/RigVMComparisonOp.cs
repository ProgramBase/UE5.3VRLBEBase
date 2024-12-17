using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMComparisonOp")]
	public partial class FRigVMComparisonOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMComparisonOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMComparisonOp()
		{
		}

		public static bool operator ==(FRigVMComparisonOp A, FRigVMComparisonOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMComparisonOp A, FRigVMComparisonOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMComparisonOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}