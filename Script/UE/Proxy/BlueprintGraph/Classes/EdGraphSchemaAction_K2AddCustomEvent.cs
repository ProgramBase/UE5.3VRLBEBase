using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddCustomEvent")]
	public partial class FEdGraphSchemaAction_K2AddCustomEvent : FEdGraphSchemaAction_K2NewNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2AddCustomEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2AddCustomEvent()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2AddCustomEvent A, FEdGraphSchemaAction_K2AddCustomEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2AddCustomEvent A, FEdGraphSchemaAction_K2AddCustomEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2AddCustomEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}