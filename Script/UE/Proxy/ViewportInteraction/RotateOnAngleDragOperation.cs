using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.RotateOnAngleDragOperation")]
	public partial class URotateOnAngleDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.RotateOnAngleDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}