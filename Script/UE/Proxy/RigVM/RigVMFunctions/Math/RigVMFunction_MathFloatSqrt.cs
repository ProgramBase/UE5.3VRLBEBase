using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatSqrt")]
	public partial class FRigVMFunction_MathFloatSqrt : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatSqrt");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatSqrt()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatSqrt A, FRigVMFunction_MathFloatSqrt B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatSqrt A, FRigVMFunction_MathFloatSqrt B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatSqrt;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}