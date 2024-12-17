using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EApplicationState")]
	public enum EApplicationState : byte
	{
		Unknown = 0,
		Inactive = 1,
		Background = 2,
		Active = 3,
	}
}