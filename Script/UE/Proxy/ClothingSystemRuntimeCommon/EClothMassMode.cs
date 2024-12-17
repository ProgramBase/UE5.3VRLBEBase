using Script.CoreUObject;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.EClothMassMode")]
	public enum EClothMassMode : byte
	{
		UniformMass = 0,
		TotalMass = 1,
		Density = 2,
		MaxClothMassMode = 3,
	}
}