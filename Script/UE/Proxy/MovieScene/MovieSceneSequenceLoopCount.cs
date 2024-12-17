using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceLoopCount")]
	public partial class FMovieSceneSequenceLoopCount : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceLoopCount");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceLoopCount() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceLoopCount() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceLoopCount A, FMovieSceneSequenceLoopCount B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceLoopCount A, FMovieSceneSequenceLoopCount B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceLoopCount;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}