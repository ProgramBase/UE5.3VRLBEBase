using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraPlatformSetState")]
	public enum ENiagaraPlatformSetState : long
	{
		Disabled = 0,
		Enabled = 1,
		Active = 2,
		Unknown = 3,
	}
}