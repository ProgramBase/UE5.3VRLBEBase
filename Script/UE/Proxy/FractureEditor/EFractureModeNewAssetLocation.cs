using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EFractureModeNewAssetLocation")]
	public enum EFractureModeNewAssetLocation : int
	{
		SourceAssetFolder = 0,
		LastUsedFolder = 1,
		ContentBrowserFolder = 2,
	}
}