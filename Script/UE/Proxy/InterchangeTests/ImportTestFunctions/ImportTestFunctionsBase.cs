using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.ImportTestFunctionsBase")]
	public partial class UImportTestFunctionsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.ImportTestFunctionsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}