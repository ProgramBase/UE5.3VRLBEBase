using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_MakeStruct")]
	public partial class FRigVMDispatch_MakeStruct : FRigVMDispatch_CoreBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_MakeStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_MakeStruct()
		{
		}

		public static bool operator ==(FRigVMDispatch_MakeStruct A, FRigVMDispatch_MakeStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_MakeStruct A, FRigVMDispatch_MakeStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_MakeStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}