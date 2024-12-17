using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ClothingSystemRuntimeNv
{
	[PathName("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv")]
	public partial class UClothingSimulationInteractorNv : UClothingSimulationInteractor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetAnimDriveDamperStiffness(float InStiffness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InStiffness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimDriveDamperStiffness, __InBuffer);
			}
		}

		private static uint __SetAnimDriveDamperStiffness = 0;
	}
}