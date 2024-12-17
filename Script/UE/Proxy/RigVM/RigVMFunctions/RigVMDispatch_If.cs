using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_If")]
	public partial class FRigVMDispatch_If : FRigVMDispatch_CoreBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_If");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_If()
		{
		}

		public static bool operator ==(FRigVMDispatch_If A, FRigVMDispatch_If B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_If A, FRigVMDispatch_If B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_If;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}