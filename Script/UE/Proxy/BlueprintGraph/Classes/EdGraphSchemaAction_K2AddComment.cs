using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddComment")]
	public partial class FEdGraphSchemaAction_K2AddComment : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2AddComment()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2AddComment A, FEdGraphSchemaAction_K2AddComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2AddComment A, FEdGraphSchemaAction_K2AddComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2AddComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}