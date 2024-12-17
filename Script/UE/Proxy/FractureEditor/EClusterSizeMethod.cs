using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EClusterSizeMethod")]
	public enum EClusterSizeMethod : byte
	{
		ByNumber = 0,
		ByFractionOfInput = 1,
		BySize = 2,
		ByGrid = 3,
	}
}