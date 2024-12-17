using Script.CoreUObject;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.EDataValidationUsecase")]
	public enum EDataValidationUsecase : byte
	{
		None = 0,
		Manual = 1,
		Commandlet = 2,
		Save = 3,
		PreSubmit = 4,
		Script = 5,
	}
}