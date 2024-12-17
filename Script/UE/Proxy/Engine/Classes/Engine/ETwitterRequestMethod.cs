using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETwitterRequestMethod")]
	public enum ETwitterRequestMethod : byte
	{
		TRM_Get = 0,
		TRM_Post = 1,
		TRM_Delete = 2,
	}
}