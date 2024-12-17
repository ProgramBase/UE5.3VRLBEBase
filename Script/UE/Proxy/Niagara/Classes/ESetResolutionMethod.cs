using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ESetResolutionMethod")]
	public enum ESetResolutionMethod : int
	{
		Independent = 0,
		MaxAxis = 1,
		CellSize = 2,
	}
}