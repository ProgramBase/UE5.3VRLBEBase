using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ELocalizedTextSourceCategory")]
	public enum ELocalizedTextSourceCategory : byte
	{
		Game = 0,
		Engine = 1,
		Editor = 2,
	}
}