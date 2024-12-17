using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionParticleSpeed")]
	public partial class UMaterialExpressionParticleSpeed : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionParticleSpeed");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}