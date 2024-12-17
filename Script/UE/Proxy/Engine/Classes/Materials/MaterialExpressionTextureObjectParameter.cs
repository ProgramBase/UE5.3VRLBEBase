using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTextureObjectParameter")]
	public partial class UMaterialExpressionTextureObjectParameter : UMaterialExpressionTextureSampleParameter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTextureObjectParameter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}