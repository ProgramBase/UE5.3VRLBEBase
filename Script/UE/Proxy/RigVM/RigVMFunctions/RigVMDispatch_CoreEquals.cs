using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_CoreEquals")]
	public partial class FRigVMDispatch_CoreEquals : FRigVMDispatch_CoreBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_CoreEquals");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_CoreEquals()
		{
		}

		public static bool operator ==(FRigVMDispatch_CoreEquals A, FRigVMDispatch_CoreEquals B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_CoreEquals A, FRigVMDispatch_CoreEquals B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_CoreEquals;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}