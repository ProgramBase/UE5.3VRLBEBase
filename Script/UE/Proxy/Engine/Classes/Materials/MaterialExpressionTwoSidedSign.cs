using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionTwoSidedSign")]
	public partial class UMaterialExpressionTwoSidedSign : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionTwoSidedSign");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}