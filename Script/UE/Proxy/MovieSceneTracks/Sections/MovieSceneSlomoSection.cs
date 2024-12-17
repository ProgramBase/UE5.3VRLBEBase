using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneSlomoSection")]
	public partial class UMovieSceneSlomoSection : UMovieSceneSection, IStaticClass
	{
		public FMovieSceneFloatChannel FloatCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatCurve, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneSlomoSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FloatCurve = 0;
	}
}