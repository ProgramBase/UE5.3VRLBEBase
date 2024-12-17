using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.InterchangeImportTestPlan")]
	public partial class UInterchangeImportTestPlan : UObject, IStaticClass
	{
		public TArray<UInterchangeImportTestStepBase> Steps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Steps, __ReturnBuffer);

					return *(TArray<UInterchangeImportTestStepBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Steps, __InBuffer);
				}
			}
		}

		public bool bIsEnabledInAutomationTests
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledInAutomationTests, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledInAutomationTests, __InBuffer);
				}
			}
		}

		public FString DisabledTestReason
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisabledTestReason, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisabledTestReason, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.InterchangeImportTestPlan");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RunThisTest()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RunThisTest);
			}
		}

		private static uint __Steps = 0;

		private static uint __bIsEnabledInAutomationTests = 0;

		private static uint __DisabledTestReason = 0;

		private static uint __RunThisTest = 0;
	}
}