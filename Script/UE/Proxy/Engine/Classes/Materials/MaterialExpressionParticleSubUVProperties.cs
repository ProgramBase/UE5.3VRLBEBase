using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionParticleSubUVProperties")]
	public partial class UMaterialExpressionParticleSubUVProperties : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionParticleSubUVProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}