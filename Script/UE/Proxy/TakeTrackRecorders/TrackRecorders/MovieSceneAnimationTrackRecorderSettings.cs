using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieSceneAnimationTrackRecorderSettings")]
	public partial class UMovieSceneAnimationTrackRecorderSettings : UMovieSceneAnimationTrackRecorderEditorSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieSceneAnimationTrackRecorderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}