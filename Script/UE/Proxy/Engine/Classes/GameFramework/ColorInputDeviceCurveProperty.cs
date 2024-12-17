using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ColorInputDeviceCurveProperty")]
	public partial class UColorInputDeviceCurveProperty : UInputDeviceProperty, IStaticClass
	{
		public FDeviceColorCurveData ColorData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorData, __ReturnBuffer);

					return *(FDeviceColorCurveData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorData, __InBuffer);
				}
			}
		}

		public TMap<FName, FDeviceColorCurveData> DeviceOverrideData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceOverrideData, __ReturnBuffer);

					return *(TMap<FName, FDeviceColorCurveData>*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ColorInputDeviceCurveProperty");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ColorData = 0;

		private static uint __DeviceOverrideData = 0;
	}
}