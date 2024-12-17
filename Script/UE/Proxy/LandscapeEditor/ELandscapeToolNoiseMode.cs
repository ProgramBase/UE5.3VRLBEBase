using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeToolNoiseMode")]
	public enum ELandscapeToolNoiseMode : sbyte
	{
		Invalid = -1,
		Both = 0,
		Add = 1,
		Sub = 2,
	}
}