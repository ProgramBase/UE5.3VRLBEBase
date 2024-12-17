using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewComment")]
	public partial class FMetasoundGraphSchemaAction_NewComment : FMetasoundGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewComment()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewComment A, FMetasoundGraphSchemaAction_NewComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewComment A, FMetasoundGraphSchemaAction_NewComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}