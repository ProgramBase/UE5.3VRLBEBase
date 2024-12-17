using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorNegate")]
	public partial class FRigVMFunction_MathVectorNegate : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorNegate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorNegate()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorNegate A, FRigVMFunction_MathVectorNegate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorNegate A, FRigVMFunction_MathVectorNegate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorNegate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}