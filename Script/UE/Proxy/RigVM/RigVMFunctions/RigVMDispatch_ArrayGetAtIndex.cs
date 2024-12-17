using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayGetAtIndex")]
	public partial class FRigVMDispatch_ArrayGetAtIndex : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayGetAtIndex");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayGetAtIndex()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayGetAtIndex A, FRigVMDispatch_ArrayGetAtIndex B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayGetAtIndex A, FRigVMDispatch_ArrayGetAtIndex B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayGetAtIndex;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}