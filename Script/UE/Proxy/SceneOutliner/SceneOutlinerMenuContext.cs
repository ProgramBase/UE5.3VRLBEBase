using Script.CoreUObject;
using Script.Library;

namespace Script.SceneOutliner
{
	[PathName("/Script/SceneOutliner.SceneOutlinerMenuContext")]
	public partial class USceneOutlinerMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SceneOutliner.SceneOutlinerMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}