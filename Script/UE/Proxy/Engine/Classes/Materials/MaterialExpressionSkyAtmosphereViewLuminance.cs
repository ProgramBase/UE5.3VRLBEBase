using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSkyAtmosphereViewLuminance")]
	public partial class UMaterialExpressionSkyAtmosphereViewLuminance : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSkyAtmosphereViewLuminance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}