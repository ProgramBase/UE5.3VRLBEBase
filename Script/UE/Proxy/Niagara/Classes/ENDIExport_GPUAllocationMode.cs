using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDIExport_GPUAllocationMode")]
	public enum ENDIExport_GPUAllocationMode : byte
	{
		FixedSize = 0,
		PerParticle = 1,
	}
}