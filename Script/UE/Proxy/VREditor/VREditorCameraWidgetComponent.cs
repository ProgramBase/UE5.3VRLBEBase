using Script.CoreUObject;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorCameraWidgetComponent")]
	public partial class UVREditorCameraWidgetComponent : UVREditorWidgetComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorCameraWidgetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}