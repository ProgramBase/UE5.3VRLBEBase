using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddEvent")]
	public partial class FEdGraphSchemaAction_K2AddEvent : FEdGraphSchemaAction_K2NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2AddEvent()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2AddEvent A, FEdGraphSchemaAction_K2AddEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2AddEvent A, FEdGraphSchemaAction_K2AddEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2AddEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}