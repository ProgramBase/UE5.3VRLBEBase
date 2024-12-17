using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSectionTemplate")]
	public partial class FMovieSceneCameraShakeSourceTriggerSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneCameraShakeSourceTriggerSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneCameraShakeSourceTriggerSectionTemplate A, FMovieSceneCameraShakeSourceTriggerSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneCameraShakeSourceTriggerSectionTemplate A, FMovieSceneCameraShakeSourceTriggerSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneCameraShakeSourceTriggerSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FFrameNumber> TriggerTimes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriggerTimes, __ReturnBuffer);

					return *(TArray<FFrameNumber>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriggerTimes, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneCameraShakeSourceTrigger> TriggerValues
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriggerValues, __ReturnBuffer);

					return *(TArray<FMovieSceneCameraShakeSourceTrigger>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriggerValues, __InBuffer);
				}
			}
		}

		private static uint __TriggerTimes = 0;

		private static uint __TriggerValues = 0;

	}
}