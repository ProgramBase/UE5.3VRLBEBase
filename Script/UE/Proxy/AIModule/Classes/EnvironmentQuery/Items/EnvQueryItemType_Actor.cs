using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryItemType_Actor")]
	public partial class UEnvQueryItemType_Actor : UEnvQueryItemType_ActorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryItemType_Actor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}