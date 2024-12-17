using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryAnimationAsset")]
	public partial class UActorFactoryAnimationAsset : UActorFactorySkeletalMesh, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryAnimationAsset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}