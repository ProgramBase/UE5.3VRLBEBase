using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.BagTestObject1Derived")]
	public partial class UBagTestObject1Derived : UBagTestObject1, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsTestSuite.BagTestObject1Derived");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}