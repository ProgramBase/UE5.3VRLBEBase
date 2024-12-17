using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieSceneVisibilityTrackRecorder")]
	public partial class UMovieSceneVisibilityTrackRecorder : UMovieSceneTrackRecorder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieSceneVisibilityTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}