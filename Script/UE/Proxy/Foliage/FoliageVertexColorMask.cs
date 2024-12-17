using Script.CoreUObject;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.FoliageVertexColorMask")]
	public enum FoliageVertexColorMask : long
	{
		FOLIAGEVERTEXCOLORMASK_Disabled = 0,
		FOLIAGEVERTEXCOLORMASK_Red = 1,
		FOLIAGEVERTEXCOLORMASK_Green = 2,
		FOLIAGEVERTEXCOLORMASK_Blue = 3,
		FOLIAGEVERTEXCOLORMASK_Alpha = 4,
	}
}