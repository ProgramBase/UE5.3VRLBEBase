using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlaneReflectionCapture")]
	public partial class APlaneReflectionCapture : AReflectionCapture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlaneReflectionCapture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}