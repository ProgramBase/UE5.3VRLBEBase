using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ActorTransformer")]
	public partial class UActorTransformer : UViewportTransformer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ActorTransformer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}