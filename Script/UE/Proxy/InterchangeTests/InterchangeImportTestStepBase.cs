using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.InterchangeImportTestStepBase")]
	public partial class UInterchangeImportTestStepBase : UObject, IStaticClass
	{
		public TArray<FInterchangeTestFunction> Tests
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tests, __ReturnBuffer);

					return *(TArray<FInterchangeTestFunction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tests, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.InterchangeImportTestStepBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Tests = 0;
	}
}