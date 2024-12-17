using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationFieldTrackPtr")]
	public partial class FMovieSceneEvaluationFieldTrackPtr : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationFieldTrackPtr");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationFieldTrackPtr() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationFieldTrackPtr() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationFieldTrackPtr A, FMovieSceneEvaluationFieldTrackPtr B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationFieldTrackPtr A, FMovieSceneEvaluationFieldTrackPtr B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationFieldTrackPtr;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneSequenceID SequenceID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SequenceID, __ReturnBuffer);

					return *(FMovieSceneSequenceID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SequenceID, __InBuffer);
				}
			}
		}

		public FMovieSceneTrackIdentifier TrackIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackIdentifier, __ReturnBuffer);

					return *(FMovieSceneTrackIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackIdentifier, __InBuffer);
				}
			}
		}

		private static uint __SequenceID = 0;

		private static uint __TrackIdentifier = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}