using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Breakpoint")]
	public partial class UDEPRECATED_Breakpoint : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Breakpoint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}