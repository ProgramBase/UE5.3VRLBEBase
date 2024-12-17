using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.MaterialExpressionLandscapeVisibilityMask")]
	public partial class UMaterialExpressionLandscapeVisibilityMask : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.MaterialExpressionLandscapeVisibilityMask");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}