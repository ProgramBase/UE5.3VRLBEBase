using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialFunctionMaterialLayerBlendInstanceFactory")]
	public partial class UMaterialFunctionMaterialLayerBlendInstanceFactory : UMaterialFunctionInstanceFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialFunctionMaterialLayerBlendInstanceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}