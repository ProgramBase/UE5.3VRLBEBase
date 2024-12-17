using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_BlueprintVariableBase")]
	public partial class FEdGraphSchemaAction_BlueprintVariableBase : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_BlueprintVariableBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_BlueprintVariableBase()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_BlueprintVariableBase A, FEdGraphSchemaAction_BlueprintVariableBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_BlueprintVariableBase A, FEdGraphSchemaAction_BlueprintVariableBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_BlueprintVariableBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}