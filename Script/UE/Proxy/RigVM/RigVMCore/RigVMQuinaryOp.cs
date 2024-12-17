using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMQuinaryOp")]
	public partial class FRigVMQuinaryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMQuinaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMQuinaryOp()
		{
		}

		public static bool operator ==(FRigVMQuinaryOp A, FRigVMQuinaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMQuinaryOp A, FRigVMQuinaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMQuinaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}