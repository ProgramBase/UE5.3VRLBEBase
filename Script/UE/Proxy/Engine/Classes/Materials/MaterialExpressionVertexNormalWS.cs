using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionVertexNormalWS")]
	public partial class UMaterialExpressionVertexNormalWS : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionVertexNormalWS");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}