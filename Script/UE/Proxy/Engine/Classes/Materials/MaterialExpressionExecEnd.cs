using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionExecEnd")]
	public partial class UMaterialExpressionExecEnd : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionExecEnd");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}