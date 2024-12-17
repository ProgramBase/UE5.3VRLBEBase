using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionIsOrthographic")]
	public partial class UMaterialExpressionIsOrthographic : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionIsOrthographic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}