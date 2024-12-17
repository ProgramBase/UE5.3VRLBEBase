using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewFromSelected")]
	public partial class FMetasoundGraphSchemaAction_NewFromSelected : FMetasoundGraphSchemaAction_NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewFromSelected");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewFromSelected()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewFromSelected A, FMetasoundGraphSchemaAction_NewFromSelected B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewFromSelected A, FMetasoundGraphSchemaAction_NewFromSelected B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewFromSelected;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}