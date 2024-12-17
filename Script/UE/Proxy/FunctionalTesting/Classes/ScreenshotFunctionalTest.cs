using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.ScreenshotFunctionalTest")]
	public partial class AScreenshotFunctionalTest : AScreenshotFunctionalTestBase, IStaticClass
	{
		public bool bCameraCutOnScreenshotPrep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCameraCutOnScreenshotPrep, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCameraCutOnScreenshotPrep, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.ScreenshotFunctionalTest");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bCameraCutOnScreenshotPrep = 0;
	}
}