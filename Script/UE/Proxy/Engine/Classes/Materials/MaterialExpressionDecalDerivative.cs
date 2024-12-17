using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionDecalDerivative")]
	public partial class UMaterialExpressionDecalDerivative : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionDecalDerivative");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}