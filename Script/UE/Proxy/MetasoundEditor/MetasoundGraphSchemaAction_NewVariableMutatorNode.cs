using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableMutatorNode")]
	public partial class FMetasoundGraphSchemaAction_NewVariableMutatorNode : FMetasoundGraphSchemaAction_NewVariableNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableMutatorNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewVariableMutatorNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewVariableMutatorNode A, FMetasoundGraphSchemaAction_NewVariableMutatorNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewVariableMutatorNode A, FMetasoundGraphSchemaAction_NewVariableMutatorNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewVariableMutatorNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}