using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NullNavSysConfig")]
	public partial class UNullNavSysConfig : UNavigationSystemConfig, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NullNavSysConfig");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}