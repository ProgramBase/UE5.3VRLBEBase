using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneFloatVectorKeyStructBase")]
	public partial class FMovieSceneFloatVectorKeyStructBase : FMovieSceneKeyStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneFloatVectorKeyStructBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneFloatVectorKeyStructBase()
		{
		}

		public static bool operator ==(FMovieSceneFloatVectorKeyStructBase A, FMovieSceneFloatVectorKeyStructBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneFloatVectorKeyStructBase A, FMovieSceneFloatVectorKeyStructBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneFloatVectorKeyStructBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameNumber Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		private static uint __Time = 0;

	}
}