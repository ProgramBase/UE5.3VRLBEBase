using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_Constant")]
	public partial class FRigVMDispatch_Constant : FRigVMDispatch_CoreBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_Constant");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_Constant()
		{
		}

		public static bool operator ==(FRigVMDispatch_Constant A, FRigVMDispatch_Constant B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_Constant A, FRigVMDispatch_Constant B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_Constant;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}