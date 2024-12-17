using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryDeferredDecal")]
	public partial class UActorFactoryDeferredDecal : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryDeferredDecal");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}