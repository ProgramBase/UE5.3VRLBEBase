namespace Script.CoreUObject
{
	public enum EGuidFormats : int
	{
		Digits = 0,
		DigitsWithHyphens = 2,
		DigitsWithHyphensLower = 3,
		DigitsWithHyphensInBraces = 4,
		DigitsWithHyphensInParentheses = 5,
		HexValuesInBraces = 6,
		UniqueObjectGuid = 7,
		Short = 8,
		Base36Encoded = 9
	}
}