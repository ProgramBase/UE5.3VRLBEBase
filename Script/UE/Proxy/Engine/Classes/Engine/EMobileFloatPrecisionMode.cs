using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMobileFloatPrecisionMode")]
	public enum EMobileFloatPrecisionMode : byte
	{
		Half = 0,
		Full_MaterialExpressionOnly = 1,
		Full = 2,
	}
}