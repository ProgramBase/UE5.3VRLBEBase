using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPixelDepth")]
	public partial class UMaterialExpressionPixelDepth : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPixelDepth");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}