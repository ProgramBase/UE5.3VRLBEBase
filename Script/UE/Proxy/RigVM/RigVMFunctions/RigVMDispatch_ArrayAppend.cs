using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayAppend")]
	public partial class FRigVMDispatch_ArrayAppend : FRigVMDispatch_ArrayBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayAppend");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayAppend()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayAppend A, FRigVMDispatch_ArrayAppend B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayAppend A, FRigVMDispatch_ArrayAppend B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayAppend;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}