using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigSubsystem")]
	public partial class UEditorConfigSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorConfig.EditorConfigSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}