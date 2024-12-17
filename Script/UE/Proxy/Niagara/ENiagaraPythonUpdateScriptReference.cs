using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraPythonUpdateScriptReference")]
	public enum ENiagaraPythonUpdateScriptReference : byte
	{
		None = 0,
		ScriptAsset = 1,
		DirectTextEntry = 2,
	}
}