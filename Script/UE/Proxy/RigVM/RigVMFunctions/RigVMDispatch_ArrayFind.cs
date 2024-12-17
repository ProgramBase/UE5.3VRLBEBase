using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayFind")]
	public partial class FRigVMDispatch_ArrayFind : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayFind");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayFind()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayFind A, FRigVMDispatch_ArrayFind B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayFind A, FRigVMDispatch_ArrayFind B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayFind;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}