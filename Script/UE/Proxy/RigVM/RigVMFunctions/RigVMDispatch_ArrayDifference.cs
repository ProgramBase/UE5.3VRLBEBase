using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayDifference")]
	public partial class FRigVMDispatch_ArrayDifference : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayDifference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayDifference()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayDifference A, FRigVMDispatch_ArrayDifference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayDifference A, FRigVMDispatch_ArrayDifference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayDifference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}