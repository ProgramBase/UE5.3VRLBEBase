using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequenceEditor
{
	[PathName("/Script/LevelSequenceEditor.LevelSequenceEditorMenuContext")]
	public partial class ULevelSequenceEditorMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequenceEditor.LevelSequenceEditorMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}