using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleMin")]
	public partial class FRigVMFunction_MathDoubleMin : FRigVMFunction_MathDoubleBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleMin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleMin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleMin A, FRigVMFunction_MathDoubleMin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleMin A, FRigVMFunction_MathDoubleMin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleMin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}