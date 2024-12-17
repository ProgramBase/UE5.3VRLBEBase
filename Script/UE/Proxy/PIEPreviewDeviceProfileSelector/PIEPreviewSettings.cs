using Script.CoreUObject;
using Script.Library;

namespace Script.PIEPreviewDeviceProfileSelector
{
	[PathName("/Script/PIEPreviewDeviceProfileSelector.PIEPreviewSettings")]
	public partial class UPIEPreviewSettings : UObject, IStaticClass
	{
		public int WindowPosX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosX, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosX, __InBuffer);
				}
			}
		}

		public int WindowPosY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosY, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosY, __InBuffer);
				}
			}
		}

		public float WindowScalingFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WindowScalingFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WindowScalingFactor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PIEPreviewDeviceProfileSelector.PIEPreviewSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WindowPosX = 0;

		private static uint __WindowPosY = 0;

		private static uint __WindowScalingFactor = 0;
	}
}