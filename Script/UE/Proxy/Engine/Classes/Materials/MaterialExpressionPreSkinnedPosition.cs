using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPreSkinnedPosition")]
	public partial class UMaterialExpressionPreSkinnedPosition : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPreSkinnedPosition");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}