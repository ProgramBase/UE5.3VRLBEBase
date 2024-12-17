using Script.CoreUObject;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.FNiagaraCompileEventSource")]
	public enum FNiagaraCompileEventSource : byte
	{
		Unset = 0,
		ScriptDependency = 1,
	}
}