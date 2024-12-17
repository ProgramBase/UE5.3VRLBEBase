using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionVertexTangentWS")]
	public partial class UMaterialExpressionVertexTangentWS : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionVertexTangentWS");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}