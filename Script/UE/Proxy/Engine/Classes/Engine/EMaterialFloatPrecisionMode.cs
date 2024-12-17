using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialFloatPrecisionMode")]
	public enum EMaterialFloatPrecisionMode : byte
	{
		MFPM_Default = 0,
		MFPM_Full_MaterialExpressionOnly = 1,
		MFPM_Full = 2,
		MFPM_Half = 3,
	}
}