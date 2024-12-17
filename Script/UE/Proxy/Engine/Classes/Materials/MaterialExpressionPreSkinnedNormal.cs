using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPreSkinnedNormal")]
	public partial class UMaterialExpressionPreSkinnedNormal : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPreSkinnedNormal");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}