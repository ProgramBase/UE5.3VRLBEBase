using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.LegacyCameraShakeFunctionLibrary")]
	public partial class ULegacyCameraShakeFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.LegacyCameraShakeFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static ULegacyCameraShake Conv_LegacyCameraShake(UCameraShakeBase CameraShake)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CameraShake?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_LegacyCameraShake, __InBuffer, __ReturnBuffer);

				return *(ULegacyCameraShake*)__ReturnBuffer;
			}
		}

		private static uint __Conv_LegacyCameraShake = 0;
	}
}