using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.BlueprintFunctionNodeSpawner")]
	public partial class UBlueprintFunctionNodeSpawner : UBlueprintFieldNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.BlueprintFunctionNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}