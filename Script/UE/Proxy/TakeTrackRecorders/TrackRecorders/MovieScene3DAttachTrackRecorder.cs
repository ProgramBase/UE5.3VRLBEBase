using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieScene3DAttachTrackRecorder")]
	public partial class UMovieScene3DAttachTrackRecorder : UMovieSceneTrackRecorder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieScene3DAttachTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}