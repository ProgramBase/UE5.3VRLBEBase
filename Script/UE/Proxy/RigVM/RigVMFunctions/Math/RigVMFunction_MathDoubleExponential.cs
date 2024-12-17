using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleExponential")]
	public partial class FRigVMFunction_MathDoubleExponential : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleExponential");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleExponential()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleExponential A, FRigVMFunction_MathDoubleExponential B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleExponential A, FRigVMFunction_MathDoubleExponential B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleExponential;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}