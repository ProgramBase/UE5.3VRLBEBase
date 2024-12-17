using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMQuaternaryOp")]
	public partial class FRigVMQuaternaryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMQuaternaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMQuaternaryOp()
		{
		}

		public static bool operator ==(FRigVMQuaternaryOp A, FRigVMQuaternaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMQuaternaryOp A, FRigVMQuaternaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMQuaternaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}