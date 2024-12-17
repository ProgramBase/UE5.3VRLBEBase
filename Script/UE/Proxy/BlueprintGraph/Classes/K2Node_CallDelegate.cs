using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_CallDelegate")]
	public partial class UK2Node_CallDelegate : UK2Node_BaseMCDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_CallDelegate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}