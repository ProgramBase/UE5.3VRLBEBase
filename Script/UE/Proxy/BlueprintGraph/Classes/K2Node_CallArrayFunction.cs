using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_CallArrayFunction")]
	public partial class UK2Node_CallArrayFunction : UK2Node_CallFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_CallArrayFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}