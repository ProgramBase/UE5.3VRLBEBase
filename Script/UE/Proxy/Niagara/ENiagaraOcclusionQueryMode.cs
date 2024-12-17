using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraOcclusionQueryMode")]
	public enum ENiagaraOcclusionQueryMode : byte
	{
		Default = 0,
		AlwaysEnabled = 1,
		AlwaysDisabled = 2,
	}
}