using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoxReflectionCapture")]
	public partial class ABoxReflectionCapture : AReflectionCapture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BoxReflectionCapture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}