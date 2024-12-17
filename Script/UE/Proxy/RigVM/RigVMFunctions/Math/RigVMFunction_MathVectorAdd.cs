using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorAdd")]
	public partial class FRigVMFunction_MathVectorAdd : FRigVMFunction_MathVectorBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorAdd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorAdd()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorAdd A, FRigVMFunction_MathVectorAdd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorAdd A, FRigVMFunction_MathVectorAdd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorAdd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}