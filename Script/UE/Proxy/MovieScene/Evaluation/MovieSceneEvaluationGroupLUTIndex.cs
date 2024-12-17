using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationGroupLUTIndex")]
	public partial class FMovieSceneEvaluationGroupLUTIndex : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationGroupLUTIndex");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationGroupLUTIndex() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationGroupLUTIndex() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationGroupLUTIndex A, FMovieSceneEvaluationGroupLUTIndex B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationGroupLUTIndex A, FMovieSceneEvaluationGroupLUTIndex B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationGroupLUTIndex;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumInitPtrs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumInitPtrs, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumInitPtrs, __InBuffer);
				}
			}
		}

		public int NumEvalPtrs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumEvalPtrs, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumEvalPtrs, __InBuffer);
				}
			}
		}

		private static uint __NumInitPtrs = 0;

		private static uint __NumEvalPtrs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}