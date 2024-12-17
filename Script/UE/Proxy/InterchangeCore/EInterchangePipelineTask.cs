using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangePipelineTask")]
	public enum EInterchangePipelineTask : byte
	{
		PostTranslator = 0,
		PostFactory = 1,
		PostImport = 2,
		Export = 3,
	}
}