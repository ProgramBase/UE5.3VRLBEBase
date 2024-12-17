using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryPlanarReflection")]
	public partial class UActorFactoryPlanarReflection : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryPlanarReflection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}