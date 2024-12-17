using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorRound")]
	public partial class FRigVMFunction_MathVectorRound : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorRound");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorRound()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorRound A, FRigVMFunction_MathVectorRound B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorRound A, FRigVMFunction_MathVectorRound B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorRound;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}