using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionObjectBounds")]
	public partial class UMaterialExpressionObjectBounds : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionObjectBounds");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}