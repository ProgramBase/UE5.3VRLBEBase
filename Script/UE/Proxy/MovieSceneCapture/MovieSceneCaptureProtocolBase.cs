using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase")]
	public partial class UMovieSceneCaptureProtocolBase : UObject, IStaticClass
	{
		public EMovieSceneCaptureProtocolState State
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __State, __ReturnBuffer);

					return *(EMovieSceneCaptureProtocolState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __State, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.MovieSceneCaptureProtocolBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsCapturing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsCapturing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EMovieSceneCaptureProtocolState GetState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetState, __ReturnBuffer);

				return *(EMovieSceneCaptureProtocolState*)__ReturnBuffer;
			}
		}

		private static uint __State = 0;

		private static uint __IsCapturing = 0;

		private static uint __GetState = 0;
	}
}