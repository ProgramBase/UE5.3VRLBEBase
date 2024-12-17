using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDISkelMesh_GpuMaxInfluences")]
	public enum ENDISkelMesh_GpuMaxInfluences : byte
	{
		AllowMax4 = 0,
		AllowMax8 = 1,
		Unlimited = 2,
	}
}