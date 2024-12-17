using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryRuntimeVirtualTextureVolume")]
	public partial class UActorFactoryRuntimeVirtualTextureVolume : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryRuntimeVirtualTextureVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}