using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialFunctionMaterialLayerBlendFactory")]
	public partial class UMaterialFunctionMaterialLayerBlendFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialFunctionMaterialLayerBlendFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}