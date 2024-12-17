using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.ScopedSlowTaskContext")]
	public partial class UScopedSlowTaskContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherRuntime.ScopedSlowTaskContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}