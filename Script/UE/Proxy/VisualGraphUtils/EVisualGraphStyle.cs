using Script.CoreUObject;

namespace Script.VisualGraphUtils
{
	[PathName("/Script/VisualGraphUtils.EVisualGraphStyle")]
	public enum EVisualGraphStyle : long
	{
		Filled = 0,
		Diagonals = 1,
		Rounded = 2,
		Dashed = 3,
		Dotted = 4,
		Solid = 5,
		Bold = 6,
	}
}