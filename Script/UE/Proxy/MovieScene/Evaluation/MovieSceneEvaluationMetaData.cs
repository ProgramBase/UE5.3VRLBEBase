using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationMetaData")]
	public partial class FMovieSceneEvaluationMetaData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationMetaData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationMetaData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationMetaData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationMetaData A, FMovieSceneEvaluationMetaData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationMetaData A, FMovieSceneEvaluationMetaData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationMetaData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMovieSceneSequenceID> ActiveSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveSequences, __ReturnBuffer);

					return *(TArray<FMovieSceneSequenceID>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveSequences, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneOrderedEvaluationKey> ActiveEntities
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveEntities, __ReturnBuffer);

					return *(TArray<FMovieSceneOrderedEvaluationKey>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveEntities, __InBuffer);
				}
			}
		}

		private static uint __ActiveSequences = 0;

		private static uint __ActiveEntities = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}