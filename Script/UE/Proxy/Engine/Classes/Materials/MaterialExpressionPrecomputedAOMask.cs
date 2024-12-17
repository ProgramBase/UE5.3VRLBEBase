using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPrecomputedAOMask")]
	public partial class UMaterialExpressionPrecomputedAOMask : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPrecomputedAOMask");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}