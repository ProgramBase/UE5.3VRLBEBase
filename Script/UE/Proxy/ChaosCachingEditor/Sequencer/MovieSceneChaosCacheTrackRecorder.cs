using Script.CoreUObject;
using Script.TakeTrackRecorders;
using Script.Library;

namespace Script.ChaosCachingEditor
{
	[PathName("/Script/ChaosCachingEditor.MovieSceneChaosCacheTrackRecorder")]
	public partial class UMovieSceneChaosCacheTrackRecorder : UMovieSceneTrackRecorder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCachingEditor.MovieSceneChaosCacheTrackRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}