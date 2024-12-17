using Script.CoreUObject;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.EReviewTopicType")]
	public enum EReviewTopicType : long
	{
		Review = 0,
		Change = 1,
		Unrecognised = 2,
	}
}