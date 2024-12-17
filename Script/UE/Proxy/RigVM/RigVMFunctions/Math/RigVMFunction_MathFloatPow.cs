using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatPow")]
	public partial class FRigVMFunction_MathFloatPow : FRigVMFunction_MathFloatBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatPow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatPow()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatPow A, FRigVMFunction_MathFloatPow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatPow A, FRigVMFunction_MathFloatPow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatPow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}