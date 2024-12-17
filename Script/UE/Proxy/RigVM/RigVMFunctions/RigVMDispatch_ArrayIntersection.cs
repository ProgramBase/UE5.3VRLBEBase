using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_ArrayIntersection")]
	public partial class FRigVMDispatch_ArrayIntersection : FRigVMDispatch_ArrayDifference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_ArrayIntersection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_ArrayIntersection()
		{
		}

		public static bool operator ==(FRigVMDispatch_ArrayIntersection A, FRigVMDispatch_ArrayIntersection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_ArrayIntersection A, FRigVMDispatch_ArrayIntersection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_ArrayIntersection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}