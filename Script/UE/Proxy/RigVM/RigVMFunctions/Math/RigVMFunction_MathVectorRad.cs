using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorRad")]
	public partial class FRigVMFunction_MathVectorRad : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorRad");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorRad()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorRad A, FRigVMFunction_MathVectorRad B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorRad A, FRigVMFunction_MathVectorRad B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorRad;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}