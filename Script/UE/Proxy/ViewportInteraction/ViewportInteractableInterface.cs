using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportInteractableInterface")]
	public partial class UViewportInteractableInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ViewportInteractableInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/ViewportInteraction.ViewportInteractableInterface")]
	public interface IViewportInteractableInterface : IInterface
	{
	}
}