using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTextureSampleParameter2D")]
	public partial class UMaterialExpressionTextureSampleParameter2D : UMaterialExpressionTextureSampleParameter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTextureSampleParameter2D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}