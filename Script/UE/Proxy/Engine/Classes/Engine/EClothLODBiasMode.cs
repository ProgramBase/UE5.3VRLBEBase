using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EClothLODBiasMode")]
	public enum EClothLODBiasMode : byte
	{
		MappingsToSameLOD = 0,
		MappingsToMinLOD = 1,
		MappingsToAnyLOD = 2,
	}
}