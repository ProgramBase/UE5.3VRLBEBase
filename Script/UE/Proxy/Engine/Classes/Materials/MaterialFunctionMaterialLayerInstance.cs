using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionMaterialLayerInstance")]
	public partial class UMaterialFunctionMaterialLayerInstance : UMaterialFunctionInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionMaterialLayerInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}