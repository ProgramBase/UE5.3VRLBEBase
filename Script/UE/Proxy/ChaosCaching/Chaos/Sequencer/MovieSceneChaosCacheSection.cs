using Script.CoreUObject;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.MovieSceneChaosCacheSection")]
	public partial class UMovieSceneChaosCacheSection : UMovieSceneBaseCacheSection, IStaticClass
	{
		public FMovieSceneChaosCacheParams Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneChaosCacheParams*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCaching.MovieSceneChaosCacheSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Params = 0;
	}
}