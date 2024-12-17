using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.StretchGizmoHandleDragOperation")]
	public partial class UStretchGizmoHandleDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.StretchGizmoHandleDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}