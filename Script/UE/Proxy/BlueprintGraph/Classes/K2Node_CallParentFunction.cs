using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_CallParentFunction")]
	public partial class UK2Node_CallParentFunction : UK2Node_CallFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_CallParentFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}