using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2Var")]
	public partial class FEdGraphSchemaAction_K2Var : FEdGraphSchemaAction_BlueprintVariableBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2Var");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2Var()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2Var A, FEdGraphSchemaAction_K2Var B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2Var A, FEdGraphSchemaAction_K2Var B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2Var;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}