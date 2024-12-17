using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathTransformMul")]
	public partial class FRigVMFunction_MathTransformMul : FRigVMFunction_MathTransformBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathTransformMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathTransformMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathTransformMul A, FRigVMFunction_MathTransformMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathTransformMul A, FRigVMFunction_MathTransformMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathTransformMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}