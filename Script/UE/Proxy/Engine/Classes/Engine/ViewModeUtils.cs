using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ViewModeUtils")]
	public partial class UViewModeUtils : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ViewModeUtils");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}