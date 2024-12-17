using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_VariableSet")]
	public partial class UK2Node_VariableSet : UK2Node_Variable, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_VariableSet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}