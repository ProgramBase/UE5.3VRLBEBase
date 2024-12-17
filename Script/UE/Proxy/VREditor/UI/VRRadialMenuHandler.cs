using Script.CoreUObject;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VRRadialMenuHandler")]
	public partial class UVRRadialMenuHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VRRadialMenuHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}