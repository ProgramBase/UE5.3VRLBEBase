using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTextureObject")]
	public partial class UMaterialExpressionTextureObject : UMaterialExpressionTextureBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTextureObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}