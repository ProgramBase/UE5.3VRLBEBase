using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMonoChannelUpmixMethod")]
	public enum EMonoChannelUpmixMethod : sbyte
	{
		Linear = 0,
		EqualPower = 1,
		FullVolume = 2,
	}
}