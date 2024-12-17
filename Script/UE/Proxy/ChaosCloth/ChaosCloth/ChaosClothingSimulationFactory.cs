using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ChaosCloth
{
	[PathName("/Script/ChaosCloth.ChaosClothingSimulationFactory")]
	public partial class UChaosClothingSimulationFactory : UClothingSimulationFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCloth.ChaosClothingSimulationFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}