using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.EScriptSource")]
	public enum EScriptSource : long
	{
		Niagara = 0,
		Game = 1,
		Plugins = 2,
		Developer = 3,
		Unknown = 4,
	}
}