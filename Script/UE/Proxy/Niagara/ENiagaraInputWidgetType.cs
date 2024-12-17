using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraInputWidgetType")]
	public enum ENiagaraInputWidgetType : byte
	{
		Default = 0,
		Slider = 1,
		Volume = 2,
		NumericDropdown = 3,
		EnumStyle = 4,
	}
}