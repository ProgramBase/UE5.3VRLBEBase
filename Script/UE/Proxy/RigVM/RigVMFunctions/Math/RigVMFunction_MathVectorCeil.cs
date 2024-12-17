using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorCeil")]
	public partial class FRigVMFunction_MathVectorCeil : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorCeil");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorCeil()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorCeil A, FRigVMFunction_MathVectorCeil B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorCeil A, FRigVMFunction_MathVectorCeil B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorCeil;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}