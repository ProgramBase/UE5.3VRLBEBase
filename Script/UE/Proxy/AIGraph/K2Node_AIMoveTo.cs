using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AIGraph
{
	[PathName("/Script/AIGraph.K2Node_AIMoveTo")]
	public partial class UK2Node_AIMoveTo : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIGraph.K2Node_AIMoveTo");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}