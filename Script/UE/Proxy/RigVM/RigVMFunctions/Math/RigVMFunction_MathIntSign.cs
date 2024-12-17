using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntSign")]
	public partial class FRigVMFunction_MathIntSign : FRigVMFunction_MathIntUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntSign");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntSign()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntSign A, FRigVMFunction_MathIntSign B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntSign A, FRigVMFunction_MathIntSign B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntSign;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}