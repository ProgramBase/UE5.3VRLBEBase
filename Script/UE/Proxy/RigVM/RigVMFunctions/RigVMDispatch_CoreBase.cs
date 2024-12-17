using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDispatch_CoreBase")]
	public partial class FRigVMDispatch_CoreBase : FRigVMDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDispatch_CoreBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDispatch_CoreBase()
		{
		}

		public static bool operator ==(FRigVMDispatch_CoreBase A, FRigVMDispatch_CoreBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDispatch_CoreBase A, FRigVMDispatch_CoreBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDispatch_CoreBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}