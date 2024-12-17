using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2Event")]
	public partial class FEdGraphSchemaAction_K2Event : FEdGraphSchemaAction_K2TargetNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2Event");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2Event()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2Event A, FEdGraphSchemaAction_K2Event B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2Event A, FEdGraphSchemaAction_K2Event B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2Event;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}