using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionDistanceCullFade")]
	public partial class UMaterialExpressionDistanceCullFade : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionDistanceCullFade");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}