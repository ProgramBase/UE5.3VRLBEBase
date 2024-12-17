using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleMax")]
	public partial class FRigVMFunction_MathDoubleMax : FRigVMFunction_MathDoubleBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleMax");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleMax()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleMax A, FRigVMFunction_MathDoubleMax B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleMax A, FRigVMFunction_MathDoubleMax B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleMax;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}