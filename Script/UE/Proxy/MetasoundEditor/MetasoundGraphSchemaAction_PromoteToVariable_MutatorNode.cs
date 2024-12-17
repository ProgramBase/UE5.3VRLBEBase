using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToVariable_MutatorNode")]
	public partial class FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode : FMetasoundGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToVariable_MutatorNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode A, FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode A, FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_PromoteToVariable_MutatorNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}