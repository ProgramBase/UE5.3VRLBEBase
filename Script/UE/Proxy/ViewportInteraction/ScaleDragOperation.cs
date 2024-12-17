using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ScaleDragOperation")]
	public partial class UScaleDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ScaleDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}