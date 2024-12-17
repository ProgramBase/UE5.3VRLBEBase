using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.MouseCursorInteractor")]
	public partial class UMouseCursorInteractor : UViewportInteractor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.MouseCursorInteractor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}