using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatAbs")]
	public partial class FRigVMFunction_MathFloatAbs : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatAbs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatAbs()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatAbs A, FRigVMFunction_MathFloatAbs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatAbs A, FRigVMFunction_MathFloatAbs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatAbs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}