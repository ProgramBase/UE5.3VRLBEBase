using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPerInstanceFadeAmount")]
	public partial class UMaterialExpressionPerInstanceFadeAmount : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPerInstanceFadeAmount");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}