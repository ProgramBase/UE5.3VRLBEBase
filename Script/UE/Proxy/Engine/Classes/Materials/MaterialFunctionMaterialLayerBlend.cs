using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionMaterialLayerBlend")]
	public partial class UMaterialFunctionMaterialLayerBlend : UMaterialFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionMaterialLayerBlend");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}