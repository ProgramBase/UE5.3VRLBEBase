using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.DataflowEditor
{
	[PathName("/Script/DataflowEditor.AssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode")]
	public partial class FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowEditor.AssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode()
		{
		}

		public static bool operator ==(FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode A, FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode A, FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetSchemaAction_Dataflow_CreateCommentNode_DataflowEdNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}