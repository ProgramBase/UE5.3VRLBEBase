using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ControlChannel")]
	public partial class UControlChannel : UChannel, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ControlChannel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}