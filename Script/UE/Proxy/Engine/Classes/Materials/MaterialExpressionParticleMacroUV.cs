using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionParticleMacroUV")]
	public partial class UMaterialExpressionParticleMacroUV : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionParticleMacroUV");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}