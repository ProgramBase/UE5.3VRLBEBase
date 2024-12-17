using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPixelNormalWS")]
	public partial class UMaterialExpressionPixelNormalWS : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPixelNormalWS");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}