using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.GameplayCamerasFunctionLibrary")]
	public partial class UGameplayCamerasFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.GameplayCamerasFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static ECameraShakePlaySpace Conv_CameraShakePlaySpace(ECameraAnimationPlaySpace CameraAnimationPlaySpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)CameraAnimationPlaySpace;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_CameraShakePlaySpace, __InBuffer, __ReturnBuffer);

				return *(ECameraShakePlaySpace*)__ReturnBuffer;
			}
		}

		public static ECameraAnimationPlaySpace Conv_CameraAnimationPlaySpace(ECameraShakePlaySpace CameraShakePlaySpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)CameraShakePlaySpace;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_CameraAnimationPlaySpace, __InBuffer, __ReturnBuffer);

				return *(ECameraAnimationPlaySpace*)__ReturnBuffer;
			}
		}

		public static UCameraAnimationCameraModifier Conv_CameraAnimationCameraModifier(APlayerCameraManager PlayerCameraManager)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerCameraManager?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_CameraAnimationCameraModifier, __InBuffer, __ReturnBuffer);

				return *(UCameraAnimationCameraModifier*)__ReturnBuffer;
			}
		}

		private static uint __Conv_CameraShakePlaySpace = 0;

		private static uint __Conv_CameraAnimationPlaySpace = 0;

		private static uint __Conv_CameraAnimationCameraModifier = 0;
	}
}