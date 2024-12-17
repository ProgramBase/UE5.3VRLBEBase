using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayBaseMutable")]
	public partial class FRigVMDispatch_ArrayBaseMutable : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayBaseMutable()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayBaseMutable A, FRigVMDispatch_ArrayBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayBaseMutable A, FRigVMDispatch_ArrayBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}