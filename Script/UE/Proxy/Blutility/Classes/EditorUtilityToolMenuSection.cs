using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityToolMenuSection")]
	public partial class UEditorUtilityToolMenuSection : UToolMenuSectionDynamic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityToolMenuSection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}