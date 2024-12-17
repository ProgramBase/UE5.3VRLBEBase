using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionCloudSampleAttribute")]
	public partial class UMaterialExpressionCloudSampleAttribute : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionCloudSampleAttribute");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}