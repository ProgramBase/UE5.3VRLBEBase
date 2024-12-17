using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackEvaluationField")]
	public partial class FMovieSceneTrackEvaluationField : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackEvaluationField");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackEvaluationField() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackEvaluationField() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackEvaluationField A, FMovieSceneTrackEvaluationField B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackEvaluationField A, FMovieSceneTrackEvaluationField B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackEvaluationField;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMovieSceneTrackEvaluationFieldEntry> Entries
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __ReturnBuffer);

					return *(TArray<FMovieSceneTrackEvaluationFieldEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Entries, __InBuffer);
				}
			}
		}

		private static uint __Entries = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}