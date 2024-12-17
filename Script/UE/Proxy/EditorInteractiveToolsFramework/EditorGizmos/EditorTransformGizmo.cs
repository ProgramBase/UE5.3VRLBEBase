using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorTransformGizmo")]
	public partial class UEditorTransformGizmo : UTransformGizmo, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorTransformGizmo");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}