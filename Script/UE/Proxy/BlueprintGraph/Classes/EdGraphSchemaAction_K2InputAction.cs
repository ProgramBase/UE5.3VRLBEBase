using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2InputAction")]
	public partial class FEdGraphSchemaAction_K2InputAction : FEdGraphSchemaAction_K2TargetNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2InputAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2InputAction()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2InputAction A, FEdGraphSchemaAction_K2InputAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2InputAction A, FEdGraphSchemaAction_K2InputAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2InputAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}