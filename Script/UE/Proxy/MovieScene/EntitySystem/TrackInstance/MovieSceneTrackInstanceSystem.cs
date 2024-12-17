using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackInstanceSystem")]
	public partial class UMovieSceneTrackInstanceSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public UMovieSceneTrackInstanceInstantiator Instantiator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Instantiator, __ReturnBuffer);

					return *(UMovieSceneTrackInstanceInstantiator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Instantiator, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneTrackInstanceSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Instantiator = 0;
	}
}