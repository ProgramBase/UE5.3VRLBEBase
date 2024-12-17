using Script.CoreUObject;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.EInterchangePipelineConfigurationDialogResult")]
	public enum EInterchangePipelineConfigurationDialogResult : byte
	{
		Cancel = 0,
		Import = 1,
		ImportAll = 2,
	}
}