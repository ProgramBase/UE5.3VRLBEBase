using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayReverse")]
	public partial class FRigVMDispatch_ArrayReverse : FRigVMDispatch_ArrayReset, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayReverse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayReverse()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayReverse A, FRigVMDispatch_ArrayReverse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayReverse A, FRigVMDispatch_ArrayReverse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayReverse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}