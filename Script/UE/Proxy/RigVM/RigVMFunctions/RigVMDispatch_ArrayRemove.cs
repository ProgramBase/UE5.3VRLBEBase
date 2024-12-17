using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayRemove")]
	public partial class FRigVMDispatch_ArrayRemove : FRigVMDispatch_ArrayBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayRemove");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayRemove()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayRemove A, FRigVMDispatch_ArrayRemove B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayRemove A, FRigVMDispatch_ArrayRemove B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayRemove;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}