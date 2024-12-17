using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatAdd")]
	public partial class FRigVMFunction_MathFloatAdd : FRigVMFunction_MathFloatBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatAdd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatAdd()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatAdd A, FRigVMFunction_MathFloatAdd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatAdd A, FRigVMFunction_MathFloatAdd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatAdd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}