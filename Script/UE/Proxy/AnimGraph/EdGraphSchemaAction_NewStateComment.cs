using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.EdGraphSchemaAction_NewStateComment")]
	public partial class FEdGraphSchemaAction_NewStateComment : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraph.EdGraphSchemaAction_NewStateComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_NewStateComment()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_NewStateComment A, FEdGraphSchemaAction_NewStateComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_NewStateComment A, FEdGraphSchemaAction_NewStateComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_NewStateComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}