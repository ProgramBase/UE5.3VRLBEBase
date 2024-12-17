using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntMin")]
	public partial class FRigVMFunction_MathIntMin : FRigVMFunction_MathIntBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntMin");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntMin()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntMin A, FRigVMFunction_MathIntMin B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntMin A, FRigVMFunction_MathIntMin B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntMin;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}