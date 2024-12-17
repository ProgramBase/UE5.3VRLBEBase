using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneFloatPerlinNoiseChannelContainer")]
	public partial class UMovieSceneFloatPerlinNoiseChannelContainer : UMovieSceneChannelOverrideContainer, IStaticClass
	{
		public FMovieSceneFloatPerlinNoiseChannel PerlinNoiseChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerlinNoiseChannel, __ReturnBuffer);

					return *(FMovieSceneFloatPerlinNoiseChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerlinNoiseChannel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneFloatPerlinNoiseChannelContainer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PerlinNoiseChannel = 0;
	}
}