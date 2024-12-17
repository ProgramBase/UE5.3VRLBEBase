using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_LinkedAnimGraph")]
	public partial class UAnimBlueprintExtension_LinkedAnimGraph : UAnimBlueprintExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_LinkedAnimGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}