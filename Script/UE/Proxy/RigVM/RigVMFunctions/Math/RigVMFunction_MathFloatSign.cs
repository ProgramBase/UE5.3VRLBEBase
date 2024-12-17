using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatSign")]
	public partial class FRigVMFunction_MathFloatSign : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatSign");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatSign()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatSign A, FRigVMFunction_MathFloatSign B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatSign A, FRigVMFunction_MathFloatSign B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatSign;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}