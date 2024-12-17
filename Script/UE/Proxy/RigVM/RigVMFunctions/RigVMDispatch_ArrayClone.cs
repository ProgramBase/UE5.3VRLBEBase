using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayClone")]
	public partial class FRigVMDispatch_ArrayClone : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayClone");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayClone()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayClone A, FRigVMDispatch_ArrayClone B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayClone A, FRigVMDispatch_ArrayClone B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayClone;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}