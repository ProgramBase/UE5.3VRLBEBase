using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISenseConfig_Touch")]
	public partial class UAISenseConfig_Touch : UAISenseConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISenseConfig_Touch");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}