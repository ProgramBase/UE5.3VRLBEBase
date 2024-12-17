using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionDeltaTime")]
	public partial class UMaterialExpressionDeltaTime : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionDeltaTime");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}