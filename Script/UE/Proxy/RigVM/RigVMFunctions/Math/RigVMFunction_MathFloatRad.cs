using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatRad")]
	public partial class FRigVMFunction_MathFloatRad : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatRad");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatRad()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatRad A, FRigVMFunction_MathFloatRad B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatRad A, FRigVMFunction_MathFloatRad B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatRad;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}