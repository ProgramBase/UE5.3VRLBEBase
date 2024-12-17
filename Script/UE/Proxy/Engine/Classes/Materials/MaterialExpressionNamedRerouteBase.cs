using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionNamedRerouteBase")]
	public partial class UMaterialExpressionNamedRerouteBase : UMaterialExpressionRerouteBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionNamedRerouteBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}