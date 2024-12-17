using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathMatrixInverse")]
	public partial class FRigVMFunction_MathMatrixInverse : FRigVMFunction_MathMatrixUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathMatrixInverse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathMatrixInverse()
		{
		}

		public static bool operator ==(FRigVMFunction_MathMatrixInverse A, FRigVMFunction_MathMatrixInverse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathMatrixInverse A, FRigVMFunction_MathMatrixInverse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathMatrixInverse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}