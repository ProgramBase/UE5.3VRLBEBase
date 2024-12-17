using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathQuaternionMul")]
	public partial class FRigVMFunction_MathQuaternionMul : FRigVMFunction_MathQuaternionBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathQuaternionMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathQuaternionMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathQuaternionMul A, FRigVMFunction_MathQuaternionMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathQuaternionMul A, FRigVMFunction_MathQuaternionMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathQuaternionMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}