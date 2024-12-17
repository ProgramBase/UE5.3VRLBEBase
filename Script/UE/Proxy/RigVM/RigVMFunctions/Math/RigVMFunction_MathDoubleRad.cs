using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleRad")]
	public partial class FRigVMFunction_MathDoubleRad : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleRad");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleRad()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleRad A, FRigVMFunction_MathDoubleRad B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleRad A, FRigVMFunction_MathDoubleRad B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleRad;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}