using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtilsTestSuite
{
	[PathName("/Script/StructUtilsTestSuite.BagTestObject1")]
	public partial class UBagTestObject1 : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsTestSuite.BagTestObject1");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}