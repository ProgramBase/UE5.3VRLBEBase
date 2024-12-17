using Script.CoreUObject;
using Script.Library;

namespace Script.HardwareTargeting
{
	[PathName("/Script/HardwareTargeting.HardwareTargetingSettings")]
	public partial class UHardwareTargetingSettings : UObject, IStaticClass
	{
		public EHardwareClass TargetedHardwareClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetedHardwareClass, __ReturnBuffer);

					return *(EHardwareClass*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetedHardwareClass, __InBuffer);
				}
			}
		}

		public EHardwareClass AppliedTargetedHardwareClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedTargetedHardwareClass, __ReturnBuffer);

					return *(EHardwareClass*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedTargetedHardwareClass, __InBuffer);
				}
			}
		}

		public EGraphicsPreset DefaultGraphicsPerformance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultGraphicsPerformance, __ReturnBuffer);

					return *(EGraphicsPreset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultGraphicsPerformance, __InBuffer);
				}
			}
		}

		public EGraphicsPreset AppliedDefaultGraphicsPerformance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedDefaultGraphicsPerformance, __ReturnBuffer);

					return *(EGraphicsPreset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AppliedDefaultGraphicsPerformance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HardwareTargeting.HardwareTargetingSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TargetedHardwareClass = 0;

		private static uint __AppliedTargetedHardwareClass = 0;

		private static uint __DefaultGraphicsPerformance = 0;

		private static uint __AppliedDefaultGraphicsPerformance = 0;
	}
}