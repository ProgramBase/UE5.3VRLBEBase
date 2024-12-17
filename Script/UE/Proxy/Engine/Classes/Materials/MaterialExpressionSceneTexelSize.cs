using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSceneTexelSize")]
	public partial class UMaterialExpressionSceneTexelSize : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSceneTexelSize");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}