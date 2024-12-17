using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPinContainerType")]
	public enum EPinContainerType : byte
	{
		None = 0,
		Array = 1,
		Set = 2,
		Map = 3,
	}
}