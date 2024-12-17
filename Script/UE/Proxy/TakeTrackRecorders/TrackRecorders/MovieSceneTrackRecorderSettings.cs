using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.MovieSceneTrackRecorderSettings")]
	public partial class UMovieSceneTrackRecorderSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeTrackRecorders.MovieSceneTrackRecorderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}