using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayUnion")]
	public partial class FRigVMDispatch_ArrayUnion : FRigVMDispatch_ArrayAppend, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayUnion");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayUnion()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayUnion A, FRigVMDispatch_ArrayUnion B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayUnion A, FRigVMDispatch_ArrayUnion B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayUnion;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}