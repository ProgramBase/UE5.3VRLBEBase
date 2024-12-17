using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_Paste")]
	public partial class FMetasoundGraphSchemaAction_Paste : FMetasoundGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_Paste");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_Paste()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_Paste A, FMetasoundGraphSchemaAction_Paste B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_Paste A, FMetasoundGraphSchemaAction_Paste B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_Paste;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}