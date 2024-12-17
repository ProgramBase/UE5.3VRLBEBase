using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.FunctionalTestLevelScript")]
	public partial class AFunctionalTestLevelScript : ALevelScriptActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.FunctionalTestLevelScript");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}