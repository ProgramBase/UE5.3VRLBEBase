using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaPlayerProxyInterface")]
	public partial class UMediaPlayerProxyInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaPlayerProxyInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MediaAssets.MediaPlayerProxyInterface")]
	public interface IMediaPlayerProxyInterface : IInterface
	{
	}
}