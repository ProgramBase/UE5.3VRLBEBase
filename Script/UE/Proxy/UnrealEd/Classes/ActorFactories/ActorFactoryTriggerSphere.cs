using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryTriggerSphere")]
	public partial class UActorFactoryTriggerSphere : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryTriggerSphere");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}