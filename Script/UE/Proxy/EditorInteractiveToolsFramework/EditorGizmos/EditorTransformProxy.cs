using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorTransformProxy")]
	public partial class UEditorTransformProxy : UTransformProxy, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorTransformProxy");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}