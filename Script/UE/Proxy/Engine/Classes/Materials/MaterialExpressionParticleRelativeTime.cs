using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionParticleRelativeTime")]
	public partial class UMaterialExpressionParticleRelativeTime : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionParticleRelativeTime");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}