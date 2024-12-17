using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionStrataBSDF")]
	public partial class UMaterialExpressionStrataBSDF : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionStrataBSDF");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}