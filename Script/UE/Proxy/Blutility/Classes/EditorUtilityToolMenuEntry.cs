using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityToolMenuEntry")]
	public partial class UEditorUtilityToolMenuEntry : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityToolMenuEntry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}