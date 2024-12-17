using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryLocalHeightFog")]
	public partial class UActorFactoryLocalHeightFog : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryLocalHeightFog");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}