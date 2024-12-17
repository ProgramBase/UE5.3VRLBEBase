using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoConditionalBuilder")]
	public partial class UEditorInteractiveGizmoConditionalBuilder : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoConditionalBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoConditionalBuilder")]
	public interface IEditorInteractiveGizmoConditionalBuilder : IInterface
	{
	}
}