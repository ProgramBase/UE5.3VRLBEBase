using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction")]
	public partial class FMetasoundGraphSchemaAction : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction A, FMetasoundGraphSchemaAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction A, FMetasoundGraphSchemaAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}