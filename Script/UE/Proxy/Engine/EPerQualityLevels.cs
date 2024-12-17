using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPerQualityLevels")]
	public enum EPerQualityLevels : byte
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Epic = 3,
		Cinematic = 4,
		Num = 5,
	}
}