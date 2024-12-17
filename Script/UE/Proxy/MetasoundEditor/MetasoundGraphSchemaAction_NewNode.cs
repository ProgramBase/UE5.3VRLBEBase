using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewNode")]
	public partial class FMetasoundGraphSchemaAction_NewNode : FMetasoundGraphSchemaAction_NodeWithMultipleOutputs, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewNode A, FMetasoundGraphSchemaAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewNode A, FMetasoundGraphSchemaAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}