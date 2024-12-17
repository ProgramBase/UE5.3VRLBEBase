using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryItemType_Direction")]
	public partial class UEnvQueryItemType_Direction : UEnvQueryItemType_VectorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryItemType_Direction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}