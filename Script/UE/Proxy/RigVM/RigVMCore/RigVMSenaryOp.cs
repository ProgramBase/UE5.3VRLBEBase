using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMSenaryOp")]
	public partial class FRigVMSenaryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMSenaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMSenaryOp()
		{
		}

		public static bool operator ==(FRigVMSenaryOp A, FRigVMSenaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMSenaryOp A, FRigVMSenaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMSenaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}