using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDISkelMesh_GpuUniformSamplingFormat")]
	public enum ENDISkelMesh_GpuUniformSamplingFormat : byte
	{
		Full = 0,
		Limited_24_8 = 1,
		Limited_23_9 = 2,
	}
}