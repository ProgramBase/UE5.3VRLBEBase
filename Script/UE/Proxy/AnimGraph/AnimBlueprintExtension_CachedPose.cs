using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_CachedPose")]
	public partial class UAnimBlueprintExtension_CachedPose : UAnimBlueprintExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_CachedPose");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}