using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraGpuBufferFormat")]
	public enum ENiagaraGpuBufferFormat : byte
	{
		Float = 0,
		HalfFloat = 1,
		UnsignedNormalizedByte = 2,
		Max = 3,
	}
}