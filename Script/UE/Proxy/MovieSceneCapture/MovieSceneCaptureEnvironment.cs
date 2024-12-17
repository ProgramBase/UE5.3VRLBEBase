using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.MovieSceneCaptureEnvironment")]
	public partial class UMovieSceneCaptureEnvironment : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.MovieSceneCaptureEnvironment");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool IsCaptureInProgress()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsCaptureInProgress, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetCaptureFrameNumber()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCaptureFrameNumber, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static float GetCaptureElapsedTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCaptureElapsedTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static UMovieSceneImageCaptureProtocolBase FindImageCaptureProtocol()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __FindImageCaptureProtocol, __ReturnBuffer);

				return *(UMovieSceneImageCaptureProtocolBase*)__ReturnBuffer;
			}
		}

		public static UMovieSceneAudioCaptureProtocolBase FindAudioCaptureProtocol()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __FindAudioCaptureProtocol, __ReturnBuffer);

				return *(UMovieSceneAudioCaptureProtocolBase*)__ReturnBuffer;
			}
		}

		private static uint __IsCaptureInProgress = 0;

		private static uint __GetCaptureFrameNumber = 0;

		private static uint __GetCaptureElapsedTime = 0;

		private static uint __FindImageCaptureProtocol = 0;

		private static uint __FindAudioCaptureProtocol = 0;
	}
}