using Script.CoreUObject;
using Script.Library;

namespace Script.AndroidMediaFactory
{
	[PathName("/Script/AndroidMediaFactory.AndroidMediaSettings")]
	public partial class UAndroidMediaSettings : UObject, IStaticClass
	{
		public bool CacheableVideoSampleBuffers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheableVideoSampleBuffers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheableVideoSampleBuffers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AndroidMediaFactory.AndroidMediaSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CacheableVideoSampleBuffers = 0;
	}
}