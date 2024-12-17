using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_BreakStruct")]
	public partial class FRigVMDispatch_BreakStruct : FRigVMDispatch_MakeStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_BreakStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_BreakStruct()
		{
		}

		public static bool operator ==(FRigVMDispatch_BreakStruct A, FRigVMDispatch_BreakStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_BreakStruct A, FRigVMDispatch_BreakStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_BreakStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}