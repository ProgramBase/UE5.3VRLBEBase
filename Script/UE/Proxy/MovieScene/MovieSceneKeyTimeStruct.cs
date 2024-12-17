using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneKeyTimeStruct")]
	public partial class FMovieSceneKeyTimeStruct : FMovieSceneKeyStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneKeyTimeStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneKeyTimeStruct()
		{
		}

		public static bool operator ==(FMovieSceneKeyTimeStruct A, FMovieSceneKeyTimeStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneKeyTimeStruct A, FMovieSceneKeyTimeStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneKeyTimeStruct;

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