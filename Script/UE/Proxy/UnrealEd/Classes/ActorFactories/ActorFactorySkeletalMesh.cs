using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactorySkeletalMesh")]
	public partial class UActorFactorySkeletalMesh : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactorySkeletalMesh");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}