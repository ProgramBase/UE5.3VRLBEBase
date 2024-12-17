using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayAdd")]
	public partial class FRigVMDispatch_ArrayAdd : FRigVMDispatch_ArraySetAtIndex, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayAdd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayAdd()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayAdd A, FRigVMDispatch_ArrayAdd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayAdd A, FRigVMDispatch_ArrayAdd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayAdd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}