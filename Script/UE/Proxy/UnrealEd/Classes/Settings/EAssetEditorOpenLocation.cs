using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EAssetEditorOpenLocation")]
	public enum EAssetEditorOpenLocation : byte
	{
		Default = 0,
		NewWindow = 1,
		MainWindow = 2,
		ContentBrowser = 3,
		LastDockedWindowOrNewWindow = 4,
		LastDockedWindowOrMainWindow = 5,
		LastDockedWindowOrContentBrowser = 6,
	}
}