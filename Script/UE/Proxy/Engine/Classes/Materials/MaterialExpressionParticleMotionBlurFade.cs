using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionParticleMotionBlurFade")]
	public partial class UMaterialExpressionParticleMotionBlurFade : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionParticleMotionBlurFade");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}