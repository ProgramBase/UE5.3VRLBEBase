using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.BagTestObject2")]
	public partial class UBagTestObject2 : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsTestSuite.BagTestObject2");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}