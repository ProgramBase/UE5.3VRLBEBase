using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GetInputVectorAxisValue")]
	public partial class UK2Node_GetInputVectorAxisValue : UK2Node_GetInputAxisKeyValue, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GetInputVectorAxisValue");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}