using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.LightEditorSubsystem")]
	public partial class ULightEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.LightEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}