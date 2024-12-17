using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.NodeAndChannelMappings")]
	public partial class UNodeAndChannelMappings : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.NodeAndChannelMappings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MovieScene.NodeAndChannelMappings")]
	public interface INodeAndChannelMappings : IInterface
	{
	}
}