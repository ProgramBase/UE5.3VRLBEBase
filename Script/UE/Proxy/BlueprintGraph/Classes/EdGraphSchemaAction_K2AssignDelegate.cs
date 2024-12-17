using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2AssignDelegate")]
	public partial class FEdGraphSchemaAction_K2AssignDelegate : FEdGraphSchemaAction_K2NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2AssignDelegate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2AssignDelegate()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2AssignDelegate A, FEdGraphSchemaAction_K2AssignDelegate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2AssignDelegate A, FEdGraphSchemaAction_K2AssignDelegate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2AssignDelegate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}