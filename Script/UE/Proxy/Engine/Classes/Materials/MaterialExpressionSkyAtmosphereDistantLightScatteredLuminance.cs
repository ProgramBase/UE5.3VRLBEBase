using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSkyAtmosphereDistantLightScatteredLuminance")]
	public partial class UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSkyAtmosphereDistantLightScatteredLuminance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}