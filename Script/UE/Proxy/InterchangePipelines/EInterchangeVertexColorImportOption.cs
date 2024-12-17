using Script.CoreUObject;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.EInterchangeVertexColorImportOption")]
	public enum EInterchangeVertexColorImportOption : byte
	{
		IVCIO_Replace = 0,
		IVCIO_Ignore = 1,
		IVCIO_Override = 2,
	}
}