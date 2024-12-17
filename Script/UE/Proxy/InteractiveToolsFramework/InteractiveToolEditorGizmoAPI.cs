using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveToolEditorGizmoAPI")]
	public partial class UInteractiveToolEditorGizmoAPI : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveToolEditorGizmoAPI");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InteractiveToolsFramework.InteractiveToolEditorGizmoAPI")]
	public interface IInteractiveToolEditorGizmoAPI : IInterface
	{
	}
}