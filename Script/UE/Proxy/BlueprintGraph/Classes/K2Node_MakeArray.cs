using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_MakeArray")]
	public partial class UK2Node_MakeArray : UK2Node_MakeContainer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_MakeArray");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}