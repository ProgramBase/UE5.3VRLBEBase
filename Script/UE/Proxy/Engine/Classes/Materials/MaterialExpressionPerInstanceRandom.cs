using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionPerInstanceRandom")]
	public partial class UMaterialExpressionPerInstanceRandom : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionPerInstanceRandom");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}