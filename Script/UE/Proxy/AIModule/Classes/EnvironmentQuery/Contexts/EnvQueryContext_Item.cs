using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryContext_Item")]
	public partial class UEnvQueryContext_Item : UEnvQueryContext, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryContext_Item");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}