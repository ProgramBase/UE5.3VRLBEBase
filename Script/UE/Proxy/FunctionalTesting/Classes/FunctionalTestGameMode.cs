using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.FunctionalTestGameMode")]
	public partial class AFunctionalTestGameMode : AGameModeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.FunctionalTestGameMode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}