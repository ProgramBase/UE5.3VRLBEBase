using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VirtualTexturingEditor
{
	[PathName("/Script/VirtualTexturingEditor.VirtualTextureBuilderFactory")]
	public partial class UVirtualTextureBuilderFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualTexturingEditor.VirtualTextureBuilderFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}