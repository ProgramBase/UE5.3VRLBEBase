using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneMaterialParameterSystem")]
	public partial class UMovieSceneMaterialParameterSystem : UMovieSceneEntitySystem, IStaticClass
	{
		public UMovieScenePiecewiseDoubleBlenderSystem DoubleBlenderSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleBlenderSystem, __ReturnBuffer);

					return *(UMovieScenePiecewiseDoubleBlenderSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleBlenderSystem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneMaterialParameterSystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DoubleBlenderSystem = 0;
	}
}