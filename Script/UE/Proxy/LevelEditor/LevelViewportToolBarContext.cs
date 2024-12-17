using Script.CoreUObject;
using Script.Library;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.LevelViewportToolBarContext")]
	public partial class ULevelViewportToolBarContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.LevelViewportToolBarContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}