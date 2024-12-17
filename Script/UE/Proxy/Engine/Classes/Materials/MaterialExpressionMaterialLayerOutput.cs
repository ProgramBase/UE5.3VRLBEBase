using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionMaterialLayerOutput")]
	public partial class UMaterialExpressionMaterialLayerOutput : UMaterialExpressionFunctionOutput, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionMaterialLayerOutput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}