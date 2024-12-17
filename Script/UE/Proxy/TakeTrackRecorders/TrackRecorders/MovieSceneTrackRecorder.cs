using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieSceneTrackRecorder")]
	public partial class UMovieSceneTrackRecorder : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieSceneTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}