using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneFieldEntry_EvaluationTrack")]
	public partial class FMovieSceneFieldEntry_EvaluationTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneFieldEntry_EvaluationTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneFieldEntry_EvaluationTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneFieldEntry_EvaluationTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneFieldEntry_EvaluationTrack A, FMovieSceneFieldEntry_EvaluationTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneFieldEntry_EvaluationTrack A, FMovieSceneFieldEntry_EvaluationTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneFieldEntry_EvaluationTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneEvaluationFieldTrackPtr TrackPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackPtr, __ReturnBuffer);

					return *(FMovieSceneEvaluationFieldTrackPtr*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackPtr, __InBuffer);
				}
			}
		}

		public ushort NumChildren
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumChildren, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumChildren, __InBuffer);
				}
			}
		}

		private static uint __TrackPtr = 0;

		private static uint __NumChildren = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}