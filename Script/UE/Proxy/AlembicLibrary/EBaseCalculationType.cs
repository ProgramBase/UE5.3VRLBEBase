using Script.CoreUObject;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.EBaseCalculationType")]
	public enum EBaseCalculationType : byte
	{
		None = 0,
		PercentageBased = 1,
		FixedNumber = 2,
		NoCompression = 3,
	}
}