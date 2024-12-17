using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryTargetPoint")]
	public partial class UActorFactoryTargetPoint : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryTargetPoint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}