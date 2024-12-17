using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryItemType_ActorBase")]
	public partial class UEnvQueryItemType_ActorBase : UEnvQueryItemType_VectorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryItemType_ActorBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}