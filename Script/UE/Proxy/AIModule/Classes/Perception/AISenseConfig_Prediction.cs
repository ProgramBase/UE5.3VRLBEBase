using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISenseConfig_Prediction")]
	public partial class UAISenseConfig_Prediction : UAISenseConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISenseConfig_Prediction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}