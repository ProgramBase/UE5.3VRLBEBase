using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.FrameGrabberProtocol")]
	public partial class UFrameGrabberProtocol : UMovieSceneImageCaptureProtocolBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.FrameGrabberProtocol");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}