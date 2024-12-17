using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleAcos")]
	public partial class FRigVMFunction_MathDoubleAcos : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleAcos");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleAcos()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleAcos A, FRigVMFunction_MathDoubleAcos B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleAcos A, FRigVMFunction_MathDoubleAcos B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleAcos;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}