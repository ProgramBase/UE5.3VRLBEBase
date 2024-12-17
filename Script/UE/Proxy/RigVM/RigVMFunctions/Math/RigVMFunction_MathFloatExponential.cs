using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatExponential")]
	public partial class FRigVMFunction_MathFloatExponential : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatExponential");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatExponential()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatExponential A, FRigVMFunction_MathFloatExponential B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatExponential A, FRigVMFunction_MathFloatExponential B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatExponential;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}