using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayMake")]
	public partial class FRigVMDispatch_ArrayMake : FRigVMDispatch_ArrayBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayMake");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayMake()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayMake A, FRigVMDispatch_ArrayMake B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayMake A, FRigVMDispatch_ArrayMake B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayMake;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}