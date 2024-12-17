using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionObjectOrientation")]
	public partial class UMaterialExpressionObjectOrientation : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionObjectOrientation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}