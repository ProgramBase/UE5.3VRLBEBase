using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleSign")]
	public partial class FRigVMFunction_MathDoubleSign : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleSign");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleSign()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleSign A, FRigVMFunction_MathDoubleSign B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleSign A, FRigVMFunction_MathDoubleSign B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleSign;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}