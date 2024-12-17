using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ContentBundleTypeFactory")]
	public partial class UContentBundleTypeFactory : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ContentBundleTypeFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}