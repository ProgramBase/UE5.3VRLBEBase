using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDIObjectPropertyReaderSourceMode")]
	public enum ENDIObjectPropertyReaderSourceMode : byte
	{
		Binding = 0,
		AttachParentActor = 1,
		BindingThenAttachParentActor = 2,
	}
}