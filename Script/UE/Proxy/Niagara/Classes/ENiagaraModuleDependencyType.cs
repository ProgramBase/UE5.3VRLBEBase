using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraModuleDependencyType")]
	public enum ENiagaraModuleDependencyType : byte
	{
		PreDependency = 0,
		PostDependency = 1,
	}
}