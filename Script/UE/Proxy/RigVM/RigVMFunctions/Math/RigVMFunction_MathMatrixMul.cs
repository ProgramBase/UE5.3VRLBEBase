using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathMatrixMul")]
	public partial class FRigVMFunction_MathMatrixMul : FRigVMFunction_MathMatrixBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathMatrixMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathMatrixMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathMatrixMul A, FRigVMFunction_MathMatrixMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathMatrixMul A, FRigVMFunction_MathMatrixMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathMatrixMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}