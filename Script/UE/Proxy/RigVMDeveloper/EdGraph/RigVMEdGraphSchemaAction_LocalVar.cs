using Script.CoreUObject;
using Script.Library;
using Script.BlueprintGraph;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_LocalVar")]
	public partial class FRigVMEdGraphSchemaAction_LocalVar : FEdGraphSchemaAction_BlueprintVariableBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMEdGraphSchemaAction_LocalVar");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMEdGraphSchemaAction_LocalVar()
		{
		}

		public static bool operator ==(FRigVMEdGraphSchemaAction_LocalVar A, FRigVMEdGraphSchemaAction_LocalVar B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMEdGraphSchemaAction_LocalVar A, FRigVMEdGraphSchemaAction_LocalVar B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMEdGraphSchemaAction_LocalVar;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}