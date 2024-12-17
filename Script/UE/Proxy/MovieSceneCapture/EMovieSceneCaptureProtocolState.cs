using Script.CoreUObject;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.EMovieSceneCaptureProtocolState")]
	public enum EMovieSceneCaptureProtocolState : byte
	{
		Idle = 0,
		Initialized = 1,
		Capturing = 2,
		Finalizing = 3,
	}
}