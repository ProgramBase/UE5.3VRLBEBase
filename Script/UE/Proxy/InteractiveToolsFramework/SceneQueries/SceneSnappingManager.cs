using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.SceneSnappingManager")]
	public partial class USceneSnappingManager : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.SceneSnappingManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}