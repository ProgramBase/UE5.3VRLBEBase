using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry_Accessory")]
	public partial class UEditorGizmoRegistryCategoryEntry_Accessory : UEditorGizmoRegistryCategoryEntry_ConditionalSelection, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry_Accessory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}