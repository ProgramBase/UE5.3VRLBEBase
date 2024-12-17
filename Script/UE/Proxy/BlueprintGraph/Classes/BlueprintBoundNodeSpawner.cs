using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.BlueprintBoundNodeSpawner")]
	public partial class UBlueprintBoundNodeSpawner : UBlueprintNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.BlueprintBoundNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}