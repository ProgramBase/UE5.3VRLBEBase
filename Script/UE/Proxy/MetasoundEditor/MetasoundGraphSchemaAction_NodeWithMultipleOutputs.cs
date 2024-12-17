using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NodeWithMultipleOutputs")]
	public partial class FMetasoundGraphSchemaAction_NodeWithMultipleOutputs : FMetasoundGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NodeWithMultipleOutputs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NodeWithMultipleOutputs()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NodeWithMultipleOutputs A, FMetasoundGraphSchemaAction_NodeWithMultipleOutputs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NodeWithMultipleOutputs A, FMetasoundGraphSchemaAction_NodeWithMultipleOutputs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NodeWithMultipleOutputs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}