using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFixedFoveationLevels")]
	public enum EFixedFoveationLevels : byte
	{
		Disabled = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		HighTop = 4,
	}
}