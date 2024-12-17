using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryPhysicsAsset")]
	public partial class UActorFactoryPhysicsAsset : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryPhysicsAsset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}