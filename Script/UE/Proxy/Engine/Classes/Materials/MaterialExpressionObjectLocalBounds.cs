using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionObjectLocalBounds")]
	public partial class UMaterialExpressionObjectLocalBounds : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionObjectLocalBounds");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}