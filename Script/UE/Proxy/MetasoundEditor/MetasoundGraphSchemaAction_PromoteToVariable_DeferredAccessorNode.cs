using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode")]
	public partial class FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode : FMetasoundGraphSchemaAction_NodeWithMultipleOutputs, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode A, FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode A, FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_PromoteToVariable_DeferredAccessorNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}