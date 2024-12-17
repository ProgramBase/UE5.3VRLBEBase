using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.PlaneTranslationDragOperation")]
	public partial class UPlaneTranslationDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.PlaneTranslationDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}