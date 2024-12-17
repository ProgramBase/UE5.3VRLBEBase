using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraScriptLibraryVisibility")]
	public enum ENiagaraScriptLibraryVisibility : byte
	{
		Invalid = 0,
		Unexposed = 1,
		Library = 2,
		Hidden = 3,
	}
}