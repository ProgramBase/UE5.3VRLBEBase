using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraBindingSource")]
	public enum ENiagaraBindingSource : byte
	{
		ImplicitFromSource = 0,
		ExplicitParticles = 1,
		ExplicitEmitter = 2,
		ExplicitSystem = 3,
		ExplicitUser = 4,
		MaxBindingSource = 5,
	}
}