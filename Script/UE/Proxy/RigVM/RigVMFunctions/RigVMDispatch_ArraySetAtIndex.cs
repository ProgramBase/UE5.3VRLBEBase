using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArraySetAtIndex")]
	public partial class FRigVMDispatch_ArraySetAtIndex : FRigVMDispatch_ArrayBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArraySetAtIndex");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArraySetAtIndex()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArraySetAtIndex A, FRigVMDispatch_ArraySetAtIndex B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArraySetAtIndex A, FRigVMDispatch_ArraySetAtIndex B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArraySetAtIndex;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}