using Script.CoreUObject;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.EReviewCommentTaskState")]
	public enum EReviewCommentTaskState : long
	{
		Comment = 0,
		Open = 1,
		Addressed = 2,
		Verified = 3,
	}
}