using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceAudioBasedVibrationProperty")]
	public partial class UInputDeviceAudioBasedVibrationProperty : UInputDeviceProperty, IStaticClass
	{
		public FAudioBasedVibrationData Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(FAudioBasedVibrationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		public TMap<FName, FAudioBasedVibrationData> DeviceOverrideData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceOverrideData, __ReturnBuffer);

					return *(TMap<FName, FAudioBasedVibrationData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceOverrideData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceAudioBasedVibrationProperty");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Data = 0;

		private static uint __DeviceOverrideData = 0;
	}
}