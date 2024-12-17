using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathMatrixBase")]
	public partial class FRigVMFunction_MathMatrixBase : FRigVMFunction_MathBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathMatrixBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathMatrixBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathMatrixBase A, FRigVMFunction_MathMatrixBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathMatrixBase A, FRigVMFunction_MathMatrixBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathMatrixBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}