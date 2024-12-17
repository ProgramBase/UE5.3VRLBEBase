using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.FunctionalTestingManager")]
	public partial class UFunctionalTestingManager : UBlueprintFunctionLibrary, IStaticClass
	{
		public TArray<AFunctionalTest> TestsLeft
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TestsLeft, __ReturnBuffer);

					return *(TArray<AFunctionalTest>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TestsLeft, __InBuffer);
				}
			}
		}

		public TArray<AFunctionalTest> AllTests
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllTests, __ReturnBuffer);

					return *(TArray<AFunctionalTest>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllTests, __InBuffer);
				}
			}
		}

		public FFunctionalTestEventSignature OnSetupTests
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSetupTests, __ReturnBuffer);

					return *(FFunctionalTestEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSetupTests, __InBuffer);
				}
			}
		}

		public FFunctionalTestEventSignature OnTestsComplete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestsComplete, __ReturnBuffer);

					return *(FFunctionalTestEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestsComplete, __InBuffer);
				}
			}
		}

		public FFunctionalTestEventSignature OnTestsBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestsBegin, __ReturnBuffer);

					return *(FFunctionalTestEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestsBegin, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.FunctionalTestingManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if any tests have been triggered
		/// </returns>
		public static bool RunAllFunctionalTests(UObject WorldContextObject, bool bNewLog = true, bool bRunLooped = false, FString FailedTestsReproString = null)
		{
			unsafe
			{
				FailedTestsReproString ??= new FString("");

				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bNewLog;

				*(bool*)(__InBuffer + 9) = bRunLooped;

				*(nint*)(__InBuffer + 10) = FailedTestsReproString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RunAllFunctionalTests, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __TestsLeft = 0;

		private static uint __AllTests = 0;

		private static uint __OnSetupTests = 0;

		private static uint __OnTestsComplete = 0;

		private static uint __OnTestsBegin = 0;

		private static uint __RunAllFunctionalTests = 0;
	}
}