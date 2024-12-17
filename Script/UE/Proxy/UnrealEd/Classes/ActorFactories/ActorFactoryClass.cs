using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryClass")]
	public partial class UActorFactoryClass : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}