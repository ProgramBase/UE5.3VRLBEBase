using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETemperatureSeverityType")]
	public enum ETemperatureSeverityType : byte
	{
		Unknown = 0,
		Good = 1,
		Bad = 2,
		Serious = 3,
		Critical = 4,
		NumSeverities = 5,
	}
}