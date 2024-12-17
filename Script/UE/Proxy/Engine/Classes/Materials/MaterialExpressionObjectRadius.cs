using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionObjectRadius")]
	public partial class UMaterialExpressionObjectRadius : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionObjectRadius");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}