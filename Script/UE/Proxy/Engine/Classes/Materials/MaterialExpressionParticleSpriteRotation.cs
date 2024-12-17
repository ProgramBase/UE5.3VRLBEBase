using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionParticleSpriteRotation")]
	public partial class UMaterialExpressionParticleSpriteRotation : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionParticleSpriteRotation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}