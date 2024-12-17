using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionLightVector")]
	public partial class UMaterialExpressionLightVector : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionLightVector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}