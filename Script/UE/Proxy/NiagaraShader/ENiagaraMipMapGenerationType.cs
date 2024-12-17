using Script.CoreUObject;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.ENiagaraMipMapGenerationType")]
	public enum ENiagaraMipMapGenerationType : byte
	{
		Unfiltered = 0,
		Linear = 1,
		Blur1 = 2,
		Blur2 = 3,
		Blur3 = 4,
		Blur4 = 5,
	}
}