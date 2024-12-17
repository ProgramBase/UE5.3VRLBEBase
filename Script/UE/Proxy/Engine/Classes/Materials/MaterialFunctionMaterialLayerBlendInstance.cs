using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionMaterialLayerBlendInstance")]
	public partial class UMaterialFunctionMaterialLayerBlendInstance : UMaterialFunctionInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionMaterialLayerBlendInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}