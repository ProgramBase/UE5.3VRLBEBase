using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactorySkyAtmosphere")]
	public partial class UActorFactorySkyAtmosphere : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactorySkyAtmosphere");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}