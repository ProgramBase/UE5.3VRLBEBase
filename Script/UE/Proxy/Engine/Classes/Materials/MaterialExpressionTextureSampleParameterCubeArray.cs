using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTextureSampleParameterCubeArray")]
	public partial class UMaterialExpressionTextureSampleParameterCubeArray : UMaterialExpressionTextureSampleParameter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTextureSampleParameterCubeArray");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}