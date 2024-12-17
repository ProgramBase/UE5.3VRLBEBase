using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieScenePropertyTrackRecorder")]
	public partial class UMovieScenePropertyTrackRecorder : UMovieSceneTrackRecorder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieScenePropertyTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}