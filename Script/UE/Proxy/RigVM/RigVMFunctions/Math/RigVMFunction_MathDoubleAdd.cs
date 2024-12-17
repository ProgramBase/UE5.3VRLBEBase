using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleAdd")]
	public partial class FRigVMFunction_MathDoubleAdd : FRigVMFunction_MathDoubleBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleAdd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleAdd()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleAdd A, FRigVMFunction_MathDoubleAdd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleAdd A, FRigVMFunction_MathDoubleAdd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleAdd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}