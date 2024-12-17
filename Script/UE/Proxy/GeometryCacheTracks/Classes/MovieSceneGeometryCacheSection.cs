using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.GeometryCacheTracks
{
	[PathName("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSection")]
	public partial class UMovieSceneGeometryCacheSection : UMovieSceneSection, IStaticClass
	{
		public FMovieSceneGeometryCacheParams Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneGeometryCacheParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Params, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Params = 0;
	}
}