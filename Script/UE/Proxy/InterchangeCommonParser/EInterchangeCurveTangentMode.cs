using Script.CoreUObject;

namespace Script.InterchangeCommonParser
{
	[PathName("/Script/InterchangeCommonParser.EInterchangeCurveTangentMode")]
	public enum EInterchangeCurveTangentMode : byte
	{
		Auto = 0,
		User = 1,
		Break = 2,
		None = 3,
	}
}