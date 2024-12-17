using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithAreaLightActorShape")]
	public enum EDatasmithAreaLightActorShape : byte
	{
		Rectangle = 0,
		Disc = 1,
		Sphere = 2,
		Cylinder = 3,
		None = 4,
	}
}