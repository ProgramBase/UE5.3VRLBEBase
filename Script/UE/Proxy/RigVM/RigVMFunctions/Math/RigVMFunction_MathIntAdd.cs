using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntAdd")]
	public partial class FRigVMFunction_MathIntAdd : FRigVMFunction_MathIntBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntAdd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntAdd()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntAdd A, FRigVMFunction_MathIntAdd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntAdd A, FRigVMFunction_MathIntAdd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntAdd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}