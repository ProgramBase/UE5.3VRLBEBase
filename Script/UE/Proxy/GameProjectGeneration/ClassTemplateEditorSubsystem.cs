using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.ClassTemplateEditorSubsystem")]
	public partial class UClassTemplateEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameProjectGeneration.ClassTemplateEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}