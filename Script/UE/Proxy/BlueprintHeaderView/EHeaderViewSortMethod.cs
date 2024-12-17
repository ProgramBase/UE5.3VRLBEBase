using Script.CoreUObject;

namespace Script.BlueprintHeaderView
{
	[PathName("/Script/BlueprintHeaderView.EHeaderViewSortMethod")]
	public enum EHeaderViewSortMethod : byte
	{
		None = 0,
		SortByAccessSpecifier = 1,
		SortForOptimalPadding = 2,
	}
}