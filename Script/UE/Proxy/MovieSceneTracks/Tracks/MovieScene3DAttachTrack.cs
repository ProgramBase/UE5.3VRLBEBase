using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScene3DAttachTrack")]
	public partial class UMovieScene3DAttachTrack : UMovieScene3DConstraintTrack, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScene3DAttachTrack");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}