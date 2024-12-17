using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSection")]
	public partial class UMovieSceneCameraShakeSourceTriggerSection : UMovieSceneSection, IStaticClass
	{
		public FMovieSceneCameraShakeSourceTriggerChannel Channel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Channel, __ReturnBuffer);

					return *(FMovieSceneCameraShakeSourceTriggerChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Channel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Channel = 0;
	}
}