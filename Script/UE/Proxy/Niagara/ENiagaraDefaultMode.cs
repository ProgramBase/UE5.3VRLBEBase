using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDefaultMode")]
	public enum ENiagaraDefaultMode : byte
	{
		Value = 0,
		Binding = 1,
		Custom = 2,
		FailIfPreviouslyNotSet = 3,
	}
}