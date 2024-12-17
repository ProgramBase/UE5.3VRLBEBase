using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionLightmapUVs")]
	public partial class UMaterialExpressionLightmapUVs : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionLightmapUVs");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}