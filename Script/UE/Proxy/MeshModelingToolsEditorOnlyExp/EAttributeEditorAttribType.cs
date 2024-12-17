using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EAttributeEditorAttribType")]
	public enum EAttributeEditorAttribType : byte
	{
		Int32 = 0,
		Boolean = 1,
		Float = 2,
		Vector2 = 3,
		Vector3 = 4,
		Vector4 = 5,
		String = 6,
		Unknown = 7,
	}
}