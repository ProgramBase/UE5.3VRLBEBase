using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraVariantMode")]
	public enum ENiagaraVariantMode : int
	{
		None = 0,
		Object = 1,
		DataInterface = 2,
		Bytes = 3,
	}
}