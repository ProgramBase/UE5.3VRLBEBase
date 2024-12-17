using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionScreenPosition")]
	public partial class UMaterialExpressionScreenPosition : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionScreenPosition");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}