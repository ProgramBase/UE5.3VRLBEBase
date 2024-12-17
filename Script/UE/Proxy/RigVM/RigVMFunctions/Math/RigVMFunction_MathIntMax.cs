using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntMax")]
	public partial class FRigVMFunction_MathIntMax : FRigVMFunction_MathIntBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntMax");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntMax()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntMax A, FRigVMFunction_MathIntMax B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntMax A, FRigVMFunction_MathIntMax B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntMax;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}