using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_SetVariableOnPersistentFrame")]
	public partial class UK2Node_SetVariableOnPersistentFrame : UK2Node, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_SetVariableOnPersistentFrame");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}