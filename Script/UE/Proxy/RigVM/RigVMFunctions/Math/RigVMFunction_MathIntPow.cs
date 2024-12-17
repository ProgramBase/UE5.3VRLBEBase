using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntPow")]
	public partial class FRigVMFunction_MathIntPow : FRigVMFunction_MathIntBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntPow");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntPow()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntPow A, FRigVMFunction_MathIntPow B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntPow A, FRigVMFunction_MathIntPow B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntPow;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}