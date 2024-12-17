using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EReimportStrategyFlags")]
	public enum EReimportStrategyFlags : byte
	{
		ApplyNoProperties = 0,
		ApplyPipelineProperties = 1,
		ApplyEditorChangedProperties = 2,
	}
}