using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayBase")]
	public partial class FRigVMDispatch_ArrayBase : FRigVMDispatch_CoreBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayBase()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayBase A, FRigVMDispatch_ArrayBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayBase A, FRigVMDispatch_ArrayBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}