using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportDragOperation")]
	public partial class UViewportDragOperation : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ViewportDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}