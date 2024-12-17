using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHitProxyPriority")]
	public enum EHitProxyPriority : byte
	{
		HPP_World = 0,
		HPP_Wireframe = 1,
		HPP_Foreground = 2,
		HPP_UI = 3,
	}
}