using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorMul")]
	public partial class FRigVMFunction_MathVectorMul : FRigVMFunction_MathVectorBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorMul A, FRigVMFunction_MathVectorMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorMul A, FRigVMFunction_MathVectorMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}