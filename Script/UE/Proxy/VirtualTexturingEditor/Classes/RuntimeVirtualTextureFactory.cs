using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VirtualTexturingEditor
{
	[PathName("/Script/VirtualTexturingEditor.RuntimeVirtualTextureFactory")]
	public partial class URuntimeVirtualTextureFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualTexturingEditor.RuntimeVirtualTextureFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}