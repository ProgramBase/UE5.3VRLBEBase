using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntMul")]
	public partial class FRigVMFunction_MathIntMul : FRigVMFunction_MathIntBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntMul");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntMul()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntMul A, FRigVMFunction_MathIntMul B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntMul A, FRigVMFunction_MathIntMul B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntMul;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}