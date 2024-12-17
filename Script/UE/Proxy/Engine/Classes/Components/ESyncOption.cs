using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESyncOption")]
	public enum ESyncOption : byte
	{
		Drive = 0,
		Passive = 1,
		Disabled = 2,
	}
}