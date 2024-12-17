using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionAtmosphericLightVector")]
	public partial class UMaterialExpressionAtmosphericLightVector : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionAtmosphericLightVector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}