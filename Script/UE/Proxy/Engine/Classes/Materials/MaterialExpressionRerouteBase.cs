using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionRerouteBase")]
	public partial class UMaterialExpressionRerouteBase : UMaterialExpression, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionRerouteBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}