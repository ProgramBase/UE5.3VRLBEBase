using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEjectNodeFromPinAction")]
	public partial class FRigVMEjectNodeFromPinAction : FRigVMInjectNodeIntoPinAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMEjectNodeFromPinAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMEjectNodeFromPinAction()
		{
		}

		public static bool operator ==(FRigVMEjectNodeFromPinAction A, FRigVMEjectNodeFromPinAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMEjectNodeFromPinAction A, FRigVMEjectNodeFromPinAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMEjectNodeFromPinAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}