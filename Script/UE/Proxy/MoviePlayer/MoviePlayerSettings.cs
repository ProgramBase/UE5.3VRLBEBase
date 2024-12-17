using Script.CoreUObject;
using Script.Library;

namespace Script.MoviePlayer
{
	[PathName("/Script/MoviePlayer.MoviePlayerSettings")]
	public partial class UMoviePlayerSettings : UObject, IStaticClass
	{
		public bool bWaitForMoviesToComplete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWaitForMoviesToComplete, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWaitForMoviesToComplete, __InBuffer);
				}
			}
		}

		public bool bMoviesAreSkippable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMoviesAreSkippable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMoviesAreSkippable, __InBuffer);
				}
			}
		}

		public TArray<FString> StartupMovies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartupMovies, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartupMovies, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MoviePlayer.MoviePlayerSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bWaitForMoviesToComplete = 0;

		private static uint __bMoviesAreSkippable = 0;

		private static uint __StartupMovies = 0;
	}
}