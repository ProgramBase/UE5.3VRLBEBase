using Script.CoreUObject;
using Script.ViewportInteraction;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.DockableWindowDragOperation")]
	public partial class UDockableWindowDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.DockableWindowDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}