using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_MakeSet")]
	public partial class UK2Node_MakeSet : UK2Node_MakeContainer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_MakeSet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}