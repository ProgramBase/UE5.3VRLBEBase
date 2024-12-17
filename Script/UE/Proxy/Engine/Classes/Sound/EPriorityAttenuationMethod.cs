using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPriorityAttenuationMethod")]
	public enum EPriorityAttenuationMethod : byte
	{
		Linear = 0,
		CustomCurve = 1,
		Manual = 2,
	}
}