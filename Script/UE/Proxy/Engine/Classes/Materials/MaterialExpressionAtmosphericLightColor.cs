using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionAtmosphericLightColor")]
	public partial class UMaterialExpressionAtmosphericLightColor : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionAtmosphericLightColor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}