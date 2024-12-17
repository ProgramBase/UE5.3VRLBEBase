using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleSqrt")]
	public partial class FRigVMFunction_MathDoubleSqrt : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleSqrt");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleSqrt()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleSqrt A, FRigVMFunction_MathDoubleSqrt B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleSqrt A, FRigVMFunction_MathDoubleSqrt B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleSqrt;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}