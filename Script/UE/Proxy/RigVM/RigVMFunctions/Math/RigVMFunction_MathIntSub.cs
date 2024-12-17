using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntSub")]
	public partial class FRigVMFunction_MathIntSub : FRigVMFunction_MathIntBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntSub");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntSub()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntSub A, FRigVMFunction_MathIntSub B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntSub A, FRigVMFunction_MathIntSub B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntSub;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}