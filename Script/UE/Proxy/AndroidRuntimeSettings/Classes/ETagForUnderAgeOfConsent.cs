using Script.CoreUObject;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.ETagForUnderAgeOfConsent")]
	public enum ETagForUnderAgeOfConsent : byte
	{
		TAG_FOR_UNDER_AGE_OF_CONSENT_UNSPECIFIED = 0,
		TAG_FOR_UNDER_AGE_OF_CONSENT_TRUE = 1,
		TAG_FOR_UNDER_AGE_OF_CONSENT_FALSE = 2,
	}
}