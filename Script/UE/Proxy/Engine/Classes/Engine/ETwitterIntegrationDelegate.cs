using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETwitterIntegrationDelegate")]
	public enum ETwitterIntegrationDelegate : long
	{
		TID_AuthorizeComplete = 0,
		TID_TweetUIComplete = 1,
		TID_RequestComplete = 2,
	}
}