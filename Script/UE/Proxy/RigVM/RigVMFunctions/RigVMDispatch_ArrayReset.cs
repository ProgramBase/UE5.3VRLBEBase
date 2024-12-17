using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayReset")]
	public partial class FRigVMDispatch_ArrayReset : FRigVMDispatch_ArrayBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayReset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayReset()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayReset A, FRigVMDispatch_ArrayReset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayReset A, FRigVMDispatch_ArrayReset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayReset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}