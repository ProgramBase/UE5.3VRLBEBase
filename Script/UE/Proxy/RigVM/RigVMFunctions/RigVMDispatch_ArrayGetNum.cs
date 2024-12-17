using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayGetNum")]
	public partial class FRigVMDispatch_ArrayGetNum : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayGetNum");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayGetNum()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayGetNum A, FRigVMDispatch_ArrayGetNum B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayGetNum A, FRigVMDispatch_ArrayGetNum B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayGetNum;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}