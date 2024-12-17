using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntAbs")]
	public partial class FRigVMFunction_MathIntAbs : FRigVMFunction_MathIntUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntAbs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntAbs()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntAbs A, FRigVMFunction_MathIntAbs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntAbs A, FRigVMFunction_MathIntAbs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntAbs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}