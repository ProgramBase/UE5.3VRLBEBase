using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneEventSectionData")]
	public partial class FMovieSceneEventSectionData : FMovieSceneChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneEventSectionData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEventSectionData()
		{
		}

		public static bool operator ==(FMovieSceneEventSectionData A, FMovieSceneEventSectionData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEventSectionData A, FMovieSceneEventSectionData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEventSectionData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FFrameNumber> Times
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Times, __ReturnBuffer);

					return *(TArray<FFrameNumber>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Times, __InBuffer);
				}
			}
		}

		public TArray<FEventPayload> KeyValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyValues, __ReturnBuffer);

					return *(TArray<FEventPayload>*)__ReturnBuffer;
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

		private static uint __Times = 0;

		private static uint __KeyValues = 0;

		private static uint __KeyHandles = 0;

	}
}