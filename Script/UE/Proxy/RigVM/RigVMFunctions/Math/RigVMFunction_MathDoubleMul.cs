using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleMul")]
	public partial class FRigVMFunction_MathDoubleMul : FRigVMFunction_MathDoubleBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleMul A, FRigVMFunction_MathDoubleMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleMul A, FRigVMFunction_MathDoubleMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}