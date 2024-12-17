using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryTest_Random")]
	public partial class UEnvQueryTest_Random : UEnvQueryTest, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryTest_Random");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}