using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoSelectionBuilder")]
	public partial class UEditorInteractiveGizmoSelectionBuilder : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoSelectionBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoSelectionBuilder")]
	public interface IEditorInteractiveGizmoSelectionBuilder : IInterface
	{
	}
}