using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraTickBehavior")]
	public enum ENiagaraTickBehavior : byte
	{
		UsePrereqs = 0,
		UseComponentTickGroup = 1,
		ForceTickFirst = 2,
		ForceTickLast = 3,
	}
}