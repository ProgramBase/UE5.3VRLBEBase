using Script.CoreUObject;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EMetadataType")]
	public enum EMetadataType : long
	{
		None = 0,
		Bool = 1,
		Int = 2,
		Float = 3,
		String = 4,
	}
}