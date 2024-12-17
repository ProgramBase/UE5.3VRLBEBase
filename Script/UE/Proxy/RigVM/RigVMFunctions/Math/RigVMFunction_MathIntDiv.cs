using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathIntDiv")]
	public partial class FRigVMFunction_MathIntDiv : FRigVMFunction_MathIntBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathIntDiv");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathIntDiv()
		{
		}

		public static bool operator ==(FRigVMFunction_MathIntDiv A, FRigVMFunction_MathIntDiv B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathIntDiv A, FRigVMFunction_MathIntDiv B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathIntDiv;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}