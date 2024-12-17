using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.ImageSequenceProtocol")]
	public partial class UImageSequenceProtocol : UFrameGrabberProtocol, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.ImageSequenceProtocol");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}