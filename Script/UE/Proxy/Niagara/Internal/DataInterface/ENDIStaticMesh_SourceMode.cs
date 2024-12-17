using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDIStaticMesh_SourceMode")]
	public enum ENDIStaticMesh_SourceMode : byte
	{
		Default = 0,
		Source = 1,
		AttachParent = 2,
		DefaultMeshOnly = 3,
	}
}