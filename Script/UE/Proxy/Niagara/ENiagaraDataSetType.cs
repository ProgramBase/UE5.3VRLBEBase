using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDataSetType")]
	public enum ENiagaraDataSetType : byte
	{
		ParticleData = 0,
		Shared = 1,
		Event = 2,
	}
}