using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMChangeTypeOp")]
	public partial class FRigVMChangeTypeOp : FRigVMUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMChangeTypeOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMChangeTypeOp()
		{
		}

		public static bool operator ==(FRigVMChangeTypeOp A, FRigVMChangeTypeOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMChangeTypeOp A, FRigVMChangeTypeOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMChangeTypeOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}