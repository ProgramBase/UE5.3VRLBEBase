using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionVolumetricCloudEmptySpaceSkippingInput")]
	public partial class UMaterialExpressionVolumetricCloudEmptySpaceSkippingInput : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionVolumetricCloudEmptySpaceSkippingInput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}