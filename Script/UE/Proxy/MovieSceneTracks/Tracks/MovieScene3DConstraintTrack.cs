using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScene3DConstraintTrack")]
	public partial class UMovieScene3DConstraintTrack : UMovieSceneTrack, IStaticClass
	{
		public TArray<UMovieSceneSection> ConstraintSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintSections, __ReturnBuffer);

					return *(TArray<UMovieSceneSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintSections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScene3DConstraintTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ConstraintSections = 0;
	}
}