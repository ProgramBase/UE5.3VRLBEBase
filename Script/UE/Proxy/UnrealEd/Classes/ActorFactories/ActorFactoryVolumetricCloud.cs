using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryVolumetricCloud")]
	public partial class UActorFactoryVolumetricCloud : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryVolumetricCloud");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}