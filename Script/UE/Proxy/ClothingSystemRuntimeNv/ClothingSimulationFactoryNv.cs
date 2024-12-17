using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ClothingSystemRuntimeNv
{
	[PathName("/Script/ClothingSystemRuntimeNv.ClothingSimulationFactoryNv")]
	public partial class UClothingSimulationFactoryNv : UClothingSimulationFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeNv.ClothingSimulationFactoryNv");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}