using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPreSkinnedLocalBounds")]
	public partial class UMaterialExpressionPreSkinnedLocalBounds : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPreSkinnedLocalBounds");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}