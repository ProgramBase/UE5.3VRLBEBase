using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorDiv")]
	public partial class FRigVMFunction_MathVectorDiv : FRigVMFunction_MathVectorBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorDiv");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorDiv()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorDiv A, FRigVMFunction_MathVectorDiv B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorDiv A, FRigVMFunction_MathVectorDiv B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorDiv;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}