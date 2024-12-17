using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionGenericConstant")]
	public partial class UMaterialExpressionGenericConstant : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionGenericConstant");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}