using Script.CoreUObject;

namespace Script.AssetDefinition
{
	[PathName("/Script/AssetDefinition.EAssetCommandResult")]
	public enum EAssetCommandResult : long
	{
		Handled = 0,
		Unhandled = 1,
	}
}