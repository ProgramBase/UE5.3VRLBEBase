using Script.CoreUObject;
using Script.AIModule;
using Script.Library;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.TestBTDecorator_CantExecute")]
	public partial class UTestBTDecorator_CantExecute : UBTDecorator, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AITestSuite.TestBTDecorator_CantExecute");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}