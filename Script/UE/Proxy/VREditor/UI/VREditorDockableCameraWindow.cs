using Script.CoreUObject;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorDockableCameraWindow")]
	public partial class AVREditorDockableCameraWindow : AVREditorDockableWindow, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorDockableCameraWindow");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}