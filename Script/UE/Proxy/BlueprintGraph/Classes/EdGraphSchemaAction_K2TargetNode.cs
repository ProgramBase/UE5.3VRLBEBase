using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2TargetNode")]
	public partial class FEdGraphSchemaAction_K2TargetNode : FEdGraphSchemaAction_K2NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2TargetNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2TargetNode()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2TargetNode A, FEdGraphSchemaAction_K2TargetNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2TargetNode A, FEdGraphSchemaAction_K2TargetNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2TargetNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}