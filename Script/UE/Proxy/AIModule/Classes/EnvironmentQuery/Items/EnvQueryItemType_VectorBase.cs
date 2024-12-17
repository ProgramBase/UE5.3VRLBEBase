using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryItemType_VectorBase")]
	public partial class UEnvQueryItemType_VectorBase : UEnvQueryItemType, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryItemType_VectorBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}