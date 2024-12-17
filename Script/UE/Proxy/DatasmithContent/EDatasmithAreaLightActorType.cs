using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithAreaLightActorType")]
	public enum EDatasmithAreaLightActorType : byte
	{
		Point = 0,
		Spot = 1,
		IES_DEPRECATED = 2,
		Rect = 3,
	}
}