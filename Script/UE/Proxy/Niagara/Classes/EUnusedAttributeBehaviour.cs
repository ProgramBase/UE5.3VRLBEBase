using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.EUnusedAttributeBehaviour")]
	public enum EUnusedAttributeBehaviour : long
	{
		Copy = 0,
		Zero = 1,
		None = 2,
		MarkInvalid = 3,
		PassThrough = 4,
	}
}