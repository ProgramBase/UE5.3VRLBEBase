using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionCameraVectorWS")]
	public partial class UMaterialExpressionCameraVectorWS : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionCameraVectorWS");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}