using Script.CoreUObject;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.EMetasoundFrontendLiteralType")]
	public enum EMetasoundFrontendLiteralType : byte
	{
		None = 0,
		Boolean = 1,
		Integer = 2,
		Float = 3,
		String = 4,
		UObject = 5,
		NoneArray = 6,
		BooleanArray = 7,
		IntegerArray = 8,
		FloatArray = 9,
		StringArray = 10,
		UObjectArray = 11,
		Invalid = 12,
	}
}