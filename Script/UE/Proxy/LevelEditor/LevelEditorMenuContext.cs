using Script.CoreUObject;
using Script.Library;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.LevelEditorMenuContext")]
	public partial class ULevelEditorMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.LevelEditorMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}