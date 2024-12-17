using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorMax")]
	public partial class FRigVMFunction_MathVectorMax : FRigVMFunction_MathVectorBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorMax");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorMax()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorMax A, FRigVMFunction_MathVectorMax B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorMax A, FRigVMFunction_MathVectorMax B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorMax;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}