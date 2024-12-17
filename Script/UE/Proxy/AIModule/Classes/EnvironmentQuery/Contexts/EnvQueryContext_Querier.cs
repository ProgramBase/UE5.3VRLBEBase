using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryContext_Querier")]
	public partial class UEnvQueryContext_Querier : UEnvQueryContext, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryContext_Querier");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}