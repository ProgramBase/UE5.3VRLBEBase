using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_AsyncAction")]
	public partial class UK2Node_AsyncAction : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_AsyncAction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}