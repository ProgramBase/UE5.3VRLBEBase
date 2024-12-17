using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableDeferredAccessorNode")]
	public partial class FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode : FMetasoundGraphSchemaAction_NewVariableNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableDeferredAccessorNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode A, FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode A, FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewVariableDeferredAccessorNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}