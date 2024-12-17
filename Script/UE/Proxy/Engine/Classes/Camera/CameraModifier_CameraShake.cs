using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraModifier_CameraShake")]
	public partial class UCameraModifier_CameraShake : UCameraModifier, IStaticClass
	{
		public TArray<FActiveCameraShakeInfo> ActiveShakes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveShakes, __ReturnBuffer);

					return *(TArray<FActiveCameraShakeInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveShakes, __InBuffer);
				}
			}
		}

		public TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes> ExpiredPooledShakesMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExpiredPooledShakesMap, __ReturnBuffer);

					return *(TMap<TSubclassOf<UCameraShakeBase>, FPooledCameraShakes>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExpiredPooledShakesMap, __InBuffer);
				}
			}
		}

		public float SplitScreenShakeScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SplitScreenShakeScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SplitScreenShakeScale, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraModifier_CameraShake");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ActiveShakes = 0;

		private static uint __ExpiredPooledShakesMap = 0;

		private static uint __SplitScreenShakeScale = 0;
	}
}