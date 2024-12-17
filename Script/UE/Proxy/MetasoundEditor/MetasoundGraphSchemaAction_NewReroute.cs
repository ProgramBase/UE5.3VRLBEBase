using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewReroute")]
	public partial class FMetasoundGraphSchemaAction_NewReroute : FMetasoundGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewReroute");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewReroute()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewReroute A, FMetasoundGraphSchemaAction_NewReroute B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewReroute A, FMetasoundGraphSchemaAction_NewReroute B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewReroute;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}