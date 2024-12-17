using Script.CoreUObject;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.FNiagaraCompileEventSeverity")]
	public enum FNiagaraCompileEventSeverity : byte
	{
		Log = 0,
		Display = 1,
		Warning = 2,
		Error = 3,
	}
}