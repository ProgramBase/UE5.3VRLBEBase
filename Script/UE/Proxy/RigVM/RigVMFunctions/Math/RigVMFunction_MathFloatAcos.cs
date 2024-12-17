using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatAcos")]
	public partial class FRigVMFunction_MathFloatAcos : FRigVMFunction_MathFloatUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatAcos");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatAcos()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatAcos A, FRigVMFunction_MathFloatAcos B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatAcos A, FRigVMFunction_MathFloatAcos B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatAcos;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}