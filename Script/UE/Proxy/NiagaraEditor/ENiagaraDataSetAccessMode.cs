using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraDataSetAccessMode")]
	public enum ENiagaraDataSetAccessMode : long
	{
		AppendConsume = 0,
		Direct = 1,
		Num = 2,
	}
}