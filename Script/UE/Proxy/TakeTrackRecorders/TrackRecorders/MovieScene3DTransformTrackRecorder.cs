using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieScene3DTransformTrackRecorder")]
	public partial class UMovieScene3DTransformTrackRecorder : UMovieSceneTrackRecorder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieScene3DTransformTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}