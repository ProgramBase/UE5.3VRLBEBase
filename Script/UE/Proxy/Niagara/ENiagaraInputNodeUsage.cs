using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraInputNodeUsage")]
	public enum ENiagaraInputNodeUsage : byte
	{
		Undefined = 0,
		Parameter = 1,
		Attribute = 2,
		SystemConstant = 3,
		TranslatorConstant = 4,
		RapidIterationParameter = 5,
	}
}