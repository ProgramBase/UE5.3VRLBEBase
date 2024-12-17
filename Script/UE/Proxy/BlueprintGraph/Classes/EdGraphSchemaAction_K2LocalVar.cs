using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2LocalVar")]
	public partial class FEdGraphSchemaAction_K2LocalVar : FEdGraphSchemaAction_BlueprintVariableBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2LocalVar");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2LocalVar()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2LocalVar A, FEdGraphSchemaAction_K2LocalVar B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2LocalVar A, FEdGraphSchemaAction_K2LocalVar B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2LocalVar;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}