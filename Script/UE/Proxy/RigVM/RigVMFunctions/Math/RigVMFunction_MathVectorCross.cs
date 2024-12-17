using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorCross")]
	public partial class FRigVMFunction_MathVectorCross : FRigVMFunction_MathVectorBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorCross");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorCross()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorCross A, FRigVMFunction_MathVectorCross B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorCross A, FRigVMFunction_MathVectorCross B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorCross;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}