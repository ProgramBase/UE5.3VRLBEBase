using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry_Primary")]
	public partial class UEditorGizmoRegistryCategoryEntry_Primary : UEditorGizmoRegistryCategoryEntry_ConditionalSelection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry_Primary");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}