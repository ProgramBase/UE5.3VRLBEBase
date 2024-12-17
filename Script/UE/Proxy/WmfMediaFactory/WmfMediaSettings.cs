using Script.CoreUObject;
using Script.Library;

namespace Script.WmfMediaFactory
{
	[PathName("/Script/WmfMediaFactory.WmfMediaSettings")]
	public partial class UWmfMediaSettings : UObject, IStaticClass
	{
		public bool AllowNonStandardCodecs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllowNonStandardCodecs, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllowNonStandardCodecs, __InBuffer);
				}
			}
		}

		public bool LowLatency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LowLatency, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LowLatency, __InBuffer);
				}
			}
		}

		public bool NativeAudioOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NativeAudioOut, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NativeAudioOut, __InBuffer);
				}
			}
		}

		public bool HardwareAcceleratedVideoDecoding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HardwareAcceleratedVideoDecoding, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HardwareAcceleratedVideoDecoding, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WmfMediaFactory.WmfMediaSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AllowNonStandardCodecs = 0;

		private static uint __LowLatency = 0;

		private static uint __NativeAudioOut = 0;

		private static uint __HardwareAcceleratedVideoDecoding = 0;
	}
}