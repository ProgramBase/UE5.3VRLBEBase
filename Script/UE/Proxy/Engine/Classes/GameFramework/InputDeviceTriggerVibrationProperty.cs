using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputDeviceTriggerVibrationProperty")]
	public partial class UInputDeviceTriggerVibrationProperty : UInputDeviceTriggerEffect, IStaticClass
	{
		public FDeviceTriggerTriggerVibrationData TriggerData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TriggerData, __ReturnBuffer);

					return *(FDeviceTriggerTriggerVibrationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TriggerData, __InBuffer);
				}
			}
		}

		public TMap<FName, FDeviceTriggerTriggerVibrationData> DeviceOverrideData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceOverrideData, __ReturnBuffer);

					return *(TMap<FName, FDeviceTriggerTriggerVibrationData>*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputDeviceTriggerVibrationProperty");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TriggerData = 0;

		private static uint __DeviceOverrideData = 0;
	}
}