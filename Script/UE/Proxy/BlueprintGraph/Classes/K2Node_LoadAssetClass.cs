using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_LoadAssetClass")]
	public partial class UK2Node_LoadAssetClass : UK2Node_LoadAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_LoadAssetClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}