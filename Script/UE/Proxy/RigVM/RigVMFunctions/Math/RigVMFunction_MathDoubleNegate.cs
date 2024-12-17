using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleNegate")]
	public partial class FRigVMFunction_MathDoubleNegate : FRigVMFunction_MathDoubleUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleNegate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleNegate()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleNegate A, FRigVMFunction_MathDoubleNegate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleNegate A, FRigVMFunction_MathDoubleNegate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleNegate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}