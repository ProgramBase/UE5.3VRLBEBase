using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionLess")]
	public partial class UMaterialExpressionLess : UMaterialExpressionBinaryOp, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionLess");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}