using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BrushShape")]
	public partial class ABrushShape : ABrush, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BrushShape");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}