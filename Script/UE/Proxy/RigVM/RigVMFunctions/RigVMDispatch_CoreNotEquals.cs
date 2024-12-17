using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_CoreNotEquals")]
	public partial class FRigVMDispatch_CoreNotEquals : FRigVMDispatch_CoreEquals, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_CoreNotEquals");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_CoreNotEquals()
		{
		}

		public static bool operator ==(FRigVMDispatch_CoreNotEquals A, FRigVMDispatch_CoreNotEquals B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_CoreNotEquals A, FRigVMDispatch_CoreNotEquals B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_CoreNotEquals;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}