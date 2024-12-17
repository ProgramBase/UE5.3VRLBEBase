using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToOutput")]
	public partial class FMetasoundGraphSchemaAction_PromoteToOutput : FMetasoundGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_PromoteToOutput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_PromoteToOutput()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_PromoteToOutput A, FMetasoundGraphSchemaAction_PromoteToOutput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_PromoteToOutput A, FMetasoundGraphSchemaAction_PromoteToOutput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_PromoteToOutput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}