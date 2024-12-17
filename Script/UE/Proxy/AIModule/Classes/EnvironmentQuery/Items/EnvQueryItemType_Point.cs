using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryItemType_Point")]
	public partial class UEnvQueryItemType_Point : UEnvQueryItemType_VectorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryItemType_Point");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}