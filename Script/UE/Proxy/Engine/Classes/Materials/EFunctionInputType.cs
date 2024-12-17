using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFunctionInputType")]
	public enum EFunctionInputType : byte
	{
		FunctionInput_Scalar = 0,
		FunctionInput_Vector2 = 1,
		FunctionInput_Vector3 = 2,
		FunctionInput_Vector4 = 3,
		FunctionInput_Texture2D = 4,
		FunctionInput_TextureCube = 5,
		FunctionInput_Texture2DArray = 6,
		FunctionInput_VolumeTexture = 7,
		FunctionInput_StaticBool = 8,
		FunctionInput_MaterialAttributes = 9,
		FunctionInput_TextureExternal = 10,
		FunctionInput_Bool = 11,
		FunctionInput_Substrate = 12,
	}
}