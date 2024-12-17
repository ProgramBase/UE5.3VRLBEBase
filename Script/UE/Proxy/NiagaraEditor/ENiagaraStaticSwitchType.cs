using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraStaticSwitchType")]
	public enum ENiagaraStaticSwitchType : byte
	{
		Bool = 0,
		Integer = 1,
		Enum = 2,
	}
}