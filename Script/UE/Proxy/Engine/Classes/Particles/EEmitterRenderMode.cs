using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEmitterRenderMode")]
	public enum EEmitterRenderMode : byte
	{
		ERM_Normal = 0,
		ERM_Point = 1,
		ERM_Cross = 2,
		ERM_LightsOnly = 3,
		ERM_None = 4,
	}
}