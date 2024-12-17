using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_ConstructObjectFromClass")]
	public partial class UK2Node_ConstructObjectFromClass : UK2Node, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_ConstructObjectFromClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}