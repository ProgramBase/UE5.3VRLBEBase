using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneEventChannel")]
	public partial class FMovieSceneEventChannel : FMovieSceneChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneEventChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEventChannel()
		{
		}

		public static bool operator ==(FMovieSceneEventChannel A, FMovieSceneEventChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEventChannel A, FMovieSceneEventChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEventChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimes, __ReturnBuffer);

					return *(TArray<FFrameNumber>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyTimes, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneEvent> KeyValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyValues, __ReturnBuffer);

					return *(TArray<FMovieSceneEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyValues, __InBuffer);
				}
			}
		}

		public FMovieSceneKeyHandleMap KeyHandles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyHandles, __ReturnBuffer);

					return *(FMovieSceneKeyHandleMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeyHandles, __InBuffer);
				}
			}
		}

		private static uint __KeyTimes = 0;

		private static uint __KeyValues = 0;

		private static uint __KeyHandles = 0;

	}
}