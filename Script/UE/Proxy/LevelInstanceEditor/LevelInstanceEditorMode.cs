using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.LevelInstanceEditor
{
	[PathName("/Script/LevelInstanceEditor.LevelInstanceEditorMode")]
	public partial class ULevelInstanceEditorMode : UEdMode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelInstanceEditor.LevelInstanceEditorMode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}