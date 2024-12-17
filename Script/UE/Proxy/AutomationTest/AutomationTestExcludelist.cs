using Script.CoreUObject;
using Script.Library;

namespace Script.AutomationTest
{
	[PathName("/Script/AutomationTest.AutomationTestExcludelist")]
	public partial class UAutomationTestExcludelist : UObject, IStaticClass
	{
		public TArray<FAutomationTestExcludelistEntry> ExcludeTest
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludeTest, __ReturnBuffer);

					return *(TArray<FAutomationTestExcludelistEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcludeTest, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AutomationTest.AutomationTestExcludelist");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ExcludeTest = 0;
	}
}