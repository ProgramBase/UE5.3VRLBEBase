using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationGroup")]
	public partial class FMovieSceneEvaluationGroup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationGroup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationGroup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationGroup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationGroup A, FMovieSceneEvaluationGroup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationGroup A, FMovieSceneEvaluationGroup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationGroup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LUTIndices, __ReturnBuffer);

					return *(TArray<FMovieSceneEvaluationGroupLUTIndex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LUTIndices, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneFieldEntry_EvaluationTrack> TrackLUT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackLUT, __ReturnBuffer);

					return *(TArray<FMovieSceneFieldEntry_EvaluationTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackLUT, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneFieldEntry_ChildTemplate> SectionLUT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionLUT, __ReturnBuffer);

					return *(TArray<FMovieSceneFieldEntry_ChildTemplate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionLUT, __InBuffer);
				}
			}
		}

		private static uint __LUTIndices = 0;

		private static uint __TrackLUT = 0;

		private static uint __SectionLUT = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}