using Script.CoreUObject;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.EInterchangeMaterialImportOption")]
	public enum EInterchangeMaterialImportOption : byte
	{
		ImportAsMaterials = 0,
		ImportAsMaterialInstances = 1,
	}
}