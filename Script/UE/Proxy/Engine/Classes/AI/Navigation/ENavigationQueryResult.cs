using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavigationQueryResult")]
	public enum ENavigationQueryResult : byte
	{
		Invalid = 0,
		Error = 1,
		Fail = 2,
		Success = 3,
	}
}