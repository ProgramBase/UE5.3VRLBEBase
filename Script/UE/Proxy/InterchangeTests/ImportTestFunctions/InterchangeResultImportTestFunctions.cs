using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.InterchangeResultImportTestFunctions")]
	public partial class UInterchangeResultImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.InterchangeResultImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckIfErrorOrWarningWasGenerated(UInterchangeResultsContainer ResultsContainer, TSubclassOf<UInterchangeResult> ErrorOrWarningClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ResultsContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ErrorOrWarningClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckIfErrorOrWarningWasGenerated, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckIfErrorOrWarningWasGenerated = 0;
	}
}