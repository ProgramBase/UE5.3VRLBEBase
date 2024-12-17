using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESceneDepthPriorityGroup")]
	public enum ESceneDepthPriorityGroup : byte
	{
		SDPG_World = 0,
		SDPG_Foreground = 1,
	}
}