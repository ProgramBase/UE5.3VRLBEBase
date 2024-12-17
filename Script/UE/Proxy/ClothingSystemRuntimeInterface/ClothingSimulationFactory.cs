using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothingSimulationFactory")]
	public partial class UClothingSimulationFactory : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeInterface.ClothingSimulationFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}