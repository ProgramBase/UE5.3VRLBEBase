using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_PromoteToVariable")]
	public partial class FRigVMEdGraphSchemaAction_PromoteToVariable : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_PromoteToVariable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMEdGraphSchemaAction_PromoteToVariable()
		{
		}

		public static bool operator ==(FRigVMEdGraphSchemaAction_PromoteToVariable A, FRigVMEdGraphSchemaAction_PromoteToVariable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMEdGraphSchemaAction_PromoteToVariable A, FRigVMEdGraphSchemaAction_PromoteToVariable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMEdGraphSchemaAction_PromoteToVariable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}