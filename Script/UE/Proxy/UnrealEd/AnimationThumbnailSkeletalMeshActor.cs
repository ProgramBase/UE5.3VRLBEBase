using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AnimationThumbnailSkeletalMeshActor")]
	public partial class AAnimationThumbnailSkeletalMeshActor : ASkeletalMeshActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AnimationThumbnailSkeletalMeshActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}