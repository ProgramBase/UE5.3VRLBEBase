using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELumenSoftwareTracingMode")]
	public enum ELumenSoftwareTracingMode : byte
	{
		DetailTracing = 1,
		GlobalTracing = 0,
	}
}