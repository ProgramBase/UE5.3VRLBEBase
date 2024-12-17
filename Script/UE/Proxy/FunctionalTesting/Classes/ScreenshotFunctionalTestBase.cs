using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.ScreenshotFunctionalTestBase")]
	public partial class AScreenshotFunctionalTestBase : AFunctionalTest, IStaticClass
	{
		public FString Notes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Notes, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Notes, __InBuffer);
				}
			}
		}

		public UCameraComponent ScreenshotCamera
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScreenshotCamera, __ReturnBuffer);

					return *(UCameraComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScreenshotCamera, __InBuffer);
				}
			}
		}

		public FAutomationScreenshotOptions ScreenshotOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScreenshotOptions, __ReturnBuffer);

					return *(FAutomationScreenshotOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScreenshotOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.ScreenshotFunctionalTestBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Notes = 0;

		private static uint __ScreenshotCamera = 0;

		private static uint __ScreenshotOptions = 0;
	}
}