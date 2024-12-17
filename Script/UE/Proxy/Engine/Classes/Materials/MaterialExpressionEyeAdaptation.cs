using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionEyeAdaptation")]
	public partial class UMaterialExpressionEyeAdaptation : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionEyeAdaptation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}