using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ChaosCloth
{
	[PathName("/Script/ChaosCloth.ChaosClothingSimulationInteractor")]
	public partial class UChaosClothingSimulationInteractor : UClothingSimulationInteractor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCloth.ChaosClothingSimulationInteractor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}