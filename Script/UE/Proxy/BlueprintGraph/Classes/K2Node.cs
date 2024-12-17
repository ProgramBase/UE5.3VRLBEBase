using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node")]
	public partial class UK2Node : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}