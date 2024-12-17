using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangeNodeContainerType")]
	public enum EInterchangeNodeContainerType : byte
	{
		None = 0,
		TranslatedScene = 1,
		TranslatedAsset = 2,
		FactoryData = 3,
	}
}