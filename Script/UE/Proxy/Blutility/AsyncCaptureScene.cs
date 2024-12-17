using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AsyncCaptureScene")]
	public partial class UAsyncCaptureScene : UBlueprintAsyncActionBase, IStaticClass
	{
		public FOnAsyncCaptureSceneComplete Complete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __ReturnBuffer);

					return *(FOnAsyncCaptureSceneComplete*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Complete, __InBuffer);
				}
			}
		}

		public ASceneCapture2D SceneCapture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneCapture, __ReturnBuffer);

					return *(ASceneCapture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneCapture, __InBuffer);
				}
			}
		}

		public UTextureRenderTarget2D SceneCaptureRT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneCaptureRT, __ReturnBuffer);

					return *(UTextureRenderTarget2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneCaptureRT, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AsyncCaptureScene");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncCaptureScene CaptureSceneWithWarmupAsync(UCameraComponent ViewCamera, TSubclassOf<ASceneCapture2D> SceneCaptureClass, int ResX, int ResY, int WarmUpFrames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = ViewCamera?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SceneCaptureClass?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = ResX;

				*(int*)(__InBuffer + 20) = ResY;

				*(int*)(__InBuffer + 24) = WarmUpFrames;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CaptureSceneWithWarmupAsync, __InBuffer, __ReturnBuffer);

				return *(UAsyncCaptureScene*)__ReturnBuffer;
			}
		}

		public static UAsyncCaptureScene CaptureSceneAsync(UCameraComponent ViewCamera, TSubclassOf<ASceneCapture2D> SceneCaptureClass, int ResX, int ResY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ViewCamera?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SceneCaptureClass?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = ResX;

				*(int*)(__InBuffer + 20) = ResY;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CaptureSceneAsync, __InBuffer, __ReturnBuffer);

				return *(UAsyncCaptureScene*)__ReturnBuffer;
			}
		}

		private static uint __Complete = 0;

		private static uint __SceneCapture = 0;

		private static uint __SceneCaptureRT = 0;

		private static uint __CaptureSceneWithWarmupAsync = 0;

		private static uint __CaptureSceneAsync = 0;
	}
}