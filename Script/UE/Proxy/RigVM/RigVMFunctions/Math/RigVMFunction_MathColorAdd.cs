using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathColorAdd")]
	public partial class FRigVMFunction_MathColorAdd : FRigVMFunction_MathColorBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathColorAdd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathColorAdd()
		{
		}

		public static bool operator ==(FRigVMFunction_MathColorAdd A, FRigVMFunction_MathColorAdd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathColorAdd A, FRigVMFunction_MathColorAdd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathColorAdd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}