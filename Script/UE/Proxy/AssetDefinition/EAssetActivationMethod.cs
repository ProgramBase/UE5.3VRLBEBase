using Script.CoreUObject;

namespace Script.AssetDefinition
{
	[PathName("/Script/AssetDefinition.EAssetActivationMethod")]
	public enum EAssetActivationMethod : long
	{
		DoubleClicked = 0,
		Opened = 1,
		Previewed = 2,
	}
}