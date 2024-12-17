using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EDataValidationResult")]
	public enum EDataValidationResult : byte
	{
		Invalid = 0,
		Valid = 1,
		NotValidated = 2,
	}
}