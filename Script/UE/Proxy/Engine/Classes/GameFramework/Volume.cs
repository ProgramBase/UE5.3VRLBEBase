using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Volume")]
	public partial class AVolume : ABrush, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Volume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}