using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerChannel")]
	public partial class FMovieSceneCameraShakeSourceTriggerChannel : FMovieSceneChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneCameraShakeSourceTriggerChannel()
		{
		}

		public static bool operator ==(FMovieSceneCameraShakeSourceTriggerChannel A, FMovieSceneCameraShakeSourceTriggerChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneCameraShakeSourceTriggerChannel A, FMovieSceneCameraShakeSourceTriggerChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneCameraShakeSourceTriggerChannel;

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

		public TArray<FMovieSceneCameraShakeSourceTrigger> KeyValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeyValues, __ReturnBuffer);

					return *(TArray<FMovieSceneCameraShakeSourceTrigger>*)__ReturnBuffer;
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