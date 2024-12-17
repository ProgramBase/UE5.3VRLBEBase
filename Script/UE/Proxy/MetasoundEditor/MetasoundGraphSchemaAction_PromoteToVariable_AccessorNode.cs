using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToVariable_AccessorNode")]
	public partial class FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode : FMetasoundGraphSchemaAction_NodeWithMultipleOutputs, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToVariable_AccessorNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode A, FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode A, FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_PromoteToVariable_AccessorNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}