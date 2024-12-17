using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArraySetNum")]
	public partial class FRigVMDispatch_ArraySetNum : FRigVMDispatch_ArrayBaseMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArraySetNum");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArraySetNum()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArraySetNum A, FRigVMDispatch_ArraySetNum B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArraySetNum A, FRigVMDispatch_ArraySetNum B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArraySetNum;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}