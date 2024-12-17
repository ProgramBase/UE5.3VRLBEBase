using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatMul")]
	public partial class FRigVMFunction_MathFloatMul : FRigVMFunction_MathFloatBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatMul A, FRigVMFunction_MathFloatMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatMul A, FRigVMFunction_MathFloatMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}