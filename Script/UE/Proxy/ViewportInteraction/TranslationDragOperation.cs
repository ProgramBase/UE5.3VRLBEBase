using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.TranslationDragOperation")]
	public partial class UTranslationDragOperation : UViewportDragOperation, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.TranslationDragOperation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}