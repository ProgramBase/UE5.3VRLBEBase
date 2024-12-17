using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayInsert")]
	public partial class FRigVMDispatch_ArrayInsert : FRigVMDispatch_ArraySetAtIndex, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayInsert");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayInsert()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayInsert A, FRigVMDispatch_ArrayInsert B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayInsert A, FRigVMDispatch_ArrayInsert B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayInsert;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}