using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.BlueprintDelegateNodeSpawner")]
	public partial class UBlueprintDelegateNodeSpawner : UBlueprintFieldNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.BlueprintDelegateNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}