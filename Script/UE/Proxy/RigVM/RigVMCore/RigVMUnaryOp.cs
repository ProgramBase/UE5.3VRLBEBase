using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMUnaryOp")]
	public partial class FRigVMUnaryOp : FRigVMBaseOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMUnaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMUnaryOp()
		{
		}

		public static bool operator ==(FRigVMUnaryOp A, FRigVMUnaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMUnaryOp A, FRigVMUnaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMUnaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}