using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryDebugHelpers")]
	public partial class UEnvQueryDebugHelpers : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryDebugHelpers");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}