using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryBoxVolume")]
	public partial class UActorFactoryBoxVolume : UActorFactoryVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryBoxVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}