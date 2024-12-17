using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTextureSampleParameter2DArray")]
	public partial class UMaterialExpressionTextureSampleParameter2DArray : UMaterialExpressionTextureSampleParameter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTextureSampleParameter2DArray");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}