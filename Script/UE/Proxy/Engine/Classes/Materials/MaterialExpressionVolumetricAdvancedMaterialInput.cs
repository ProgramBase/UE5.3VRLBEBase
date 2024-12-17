using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialInput")]
	public partial class UMaterialExpressionVolumetricAdvancedMaterialInput : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialInput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}