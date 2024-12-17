using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.CameraAnimationSpawnableSystem")]
	public partial class UCameraAnimationSpawnableSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.CameraAnimationSpawnableSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}