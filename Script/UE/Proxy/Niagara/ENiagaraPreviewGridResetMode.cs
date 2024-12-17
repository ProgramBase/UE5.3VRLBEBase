using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraPreviewGridResetMode")]
	public enum ENiagaraPreviewGridResetMode : byte
	{
		Never = 0,
		Individual = 1,
		All = 2,
	}
}