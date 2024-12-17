using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionCustomOutput")]
	public partial class UMaterialExpressionCustomOutput : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionCustomOutput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}