using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ActorFactoryCylinderVolume")]
	public partial class UActorFactoryCylinderVolume : UActorFactoryVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ActorFactoryCylinderVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}