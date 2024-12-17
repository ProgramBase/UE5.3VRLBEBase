using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionDecalColor")]
	public partial class UMaterialExpressionDecalColor : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionDecalColor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}