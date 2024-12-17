using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleSin")]
	public partial class FRigVMFunction_MathDoubleSin : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleSin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleSin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleSin A, FRigVMFunction_MathDoubleSin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleSin A, FRigVMFunction_MathDoubleSin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleSin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}