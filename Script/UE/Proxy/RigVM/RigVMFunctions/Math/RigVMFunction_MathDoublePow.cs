using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoublePow")]
	public partial class FRigVMFunction_MathDoublePow : FRigVMFunction_MathDoubleBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoublePow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoublePow()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoublePow A, FRigVMFunction_MathDoublePow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoublePow A, FRigVMFunction_MathDoublePow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoublePow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}