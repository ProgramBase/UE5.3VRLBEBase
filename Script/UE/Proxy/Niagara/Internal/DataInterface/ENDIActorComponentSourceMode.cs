using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDIActorComponentSourceMode")]
	public enum ENDIActorComponentSourceMode : byte
	{
		Default = 0,
		AttachParent = 1,
		LocalPlayer = 2,
	}
}