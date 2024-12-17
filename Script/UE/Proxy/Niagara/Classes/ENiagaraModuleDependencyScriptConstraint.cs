using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraModuleDependencyScriptConstraint")]
	public enum ENiagaraModuleDependencyScriptConstraint : byte
	{
		SameScript = 0,
		AllScripts = 1,
	}
}