using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScene3DConstraintSection")]
	public partial class UMovieScene3DConstraintSection : UMovieSceneSection, IStaticClass
	{
		public FMovieSceneObjectBindingID ConstraintBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintBindingID, __ReturnBuffer);

					return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintBindingID, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieScene3DConstraintSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetConstraintBindingID(FMovieSceneObjectBindingID InConstraintBindingID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InConstraintBindingID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintBindingID, __InBuffer);
			}
		}

		public virtual FMovieSceneObjectBindingID GetConstraintBindingID()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetConstraintBindingID, __ReturnBuffer);

				return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
			}
		}

		private static uint __ConstraintBindingID = 0;

		private static uint __SetConstraintBindingID = 0;

		private static uint __GetConstraintBindingID = 0;
	}
}