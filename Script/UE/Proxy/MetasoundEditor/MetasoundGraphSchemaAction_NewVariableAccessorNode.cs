using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableAccessorNode")]
	public partial class FMetasoundGraphSchemaAction_NewVariableAccessorNode : FMetasoundGraphSchemaAction_NewVariableNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableAccessorNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewVariableAccessorNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewVariableAccessorNode A, FMetasoundGraphSchemaAction_NewVariableAccessorNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewVariableAccessorNode A, FMetasoundGraphSchemaAction_NewVariableAccessorNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewVariableAccessorNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}