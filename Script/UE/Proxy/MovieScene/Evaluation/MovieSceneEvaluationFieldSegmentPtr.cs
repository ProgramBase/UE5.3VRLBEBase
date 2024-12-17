using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationFieldSegmentPtr")]
	public partial class FMovieSceneEvaluationFieldSegmentPtr : FMovieSceneEvaluationFieldTrackPtr, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationFieldSegmentPtr");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationFieldSegmentPtr()
		{
		}

		public static bool operator ==(FMovieSceneEvaluationFieldSegmentPtr A, FMovieSceneEvaluationFieldSegmentPtr B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationFieldSegmentPtr A, FMovieSceneEvaluationFieldSegmentPtr B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationFieldSegmentPtr;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneSegmentIdentifier SegmentID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SegmentID, __ReturnBuffer);

					return *(FMovieSceneSegmentIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SegmentID, __InBuffer);
				}
			}
		}

		private static uint __SegmentID = 0;

	}
}