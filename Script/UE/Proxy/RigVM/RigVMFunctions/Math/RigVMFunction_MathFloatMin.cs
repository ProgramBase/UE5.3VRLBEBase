using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatMin")]
	public partial class FRigVMFunction_MathFloatMin : FRigVMFunction_MathFloatBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatMin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatMin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatMin A, FRigVMFunction_MathFloatMin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatMin A, FRigVMFunction_MathFloatMin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatMin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}