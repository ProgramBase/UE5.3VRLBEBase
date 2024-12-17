using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionCameraPositionWS")]
	public partial class UMaterialExpressionCameraPositionWS : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionCameraPositionWS");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}