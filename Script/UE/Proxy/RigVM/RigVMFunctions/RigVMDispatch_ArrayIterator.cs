using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayIterator")]
	public partial class FRigVMDispatch_ArrayIterator : FRigVMDispatch_ArrayBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayIterator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayIterator()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayIterator A, FRigVMDispatch_ArrayIterator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayIterator A, FRigVMDispatch_ArrayIterator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayIterator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}