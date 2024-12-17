using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry_ConditionalSelection")]
	public partial class UEditorGizmoRegistryCategoryEntry_ConditionalSelection : UEditorGizmoRegistryCategoryEntry, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry_ConditionalSelection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}