using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangeTranslatorType")]
	public enum EInterchangeTranslatorType : byte
	{
		Invalid = 0,
		Assets = 2,
		Actors = 4,
		Scenes = 6,
	}
}