using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryDirectionalLight")]
	public partial class UActorFactoryDirectionalLight : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryDirectionalLight");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}