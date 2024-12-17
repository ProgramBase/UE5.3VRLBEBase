using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorSign")]
	public partial class FRigVMFunction_MathVectorSign : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorSign");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorSign()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorSign A, FRigVMFunction_MathVectorSign B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorSign A, FRigVMFunction_MathVectorSign B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorSign;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}