using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationFieldSharedEntityMetaData")]
	public partial class FMovieSceneEvaluationFieldSharedEntityMetaData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationFieldSharedEntityMetaData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationFieldSharedEntityMetaData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationFieldSharedEntityMetaData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationFieldSharedEntityMetaData A, FMovieSceneEvaluationFieldSharedEntityMetaData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationFieldSharedEntityMetaData A, FMovieSceneEvaluationFieldSharedEntityMetaData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationFieldSharedEntityMetaData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ObjectBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBindingID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBindingID, __InBuffer);
				}
			}
		}

		private static uint __ObjectBindingID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}