using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathColorMul")]
	public partial class FRigVMFunction_MathColorMul : FRigVMFunction_MathColorBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathColorMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathColorMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathColorMul A, FRigVMFunction_MathColorMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathColorMul A, FRigVMFunction_MathColorMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathColorMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}