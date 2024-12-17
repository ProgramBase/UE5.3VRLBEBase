using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaSourceRendererInterface")]
	public partial class UMediaSourceRendererInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaSourceRendererInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MediaAssets.MediaSourceRendererInterface")]
	public interface IMediaSourceRendererInterface : IInterface
	{
	}
}