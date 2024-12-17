using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMReplaceNodesAction")]
	public partial class FRigVMReplaceNodesAction : FRigVMBaseAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMReplaceNodesAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMReplaceNodesAction()
		{
		}

		public static bool operator ==(FRigVMReplaceNodesAction A, FRigVMReplaceNodesAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMReplaceNodesAction A, FRigVMReplaceNodesAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMReplaceNodesAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}