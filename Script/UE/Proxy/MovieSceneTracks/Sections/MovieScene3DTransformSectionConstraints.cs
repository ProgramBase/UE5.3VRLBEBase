using Script.CoreUObject;
using Script.Library;
using Script.Constraints;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScene3DTransformSectionConstraints")]
	public partial class UMovieScene3DTransformSectionConstraints : UObject, IStaticClass
	{
		public TArray<FConstraintAndActiveChannel> ConstraintsChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintsChannels, __ReturnBuffer);

					return *(TArray<FConstraintAndActiveChannel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintsChannels, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScene3DTransformSectionConstraints");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ConstraintsChannels = 0;
	}
}