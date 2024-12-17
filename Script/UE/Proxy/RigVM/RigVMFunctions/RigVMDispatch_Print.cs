using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_Print")]
	public partial class FRigVMDispatch_Print : FRigVMDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_Print");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_Print()
		{
		}

		public static bool operator ==(FRigVMDispatch_Print A, FRigVMDispatch_Print B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_Print A, FRigVMDispatch_Print B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_Print;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}