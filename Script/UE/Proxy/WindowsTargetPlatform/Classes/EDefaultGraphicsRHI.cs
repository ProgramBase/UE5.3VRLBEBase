using Script.CoreUObject;

namespace Script.WindowsTargetPlatform
{
	[PathName("/Script/WindowsTargetPlatform.EDefaultGraphicsRHI")]
	public enum EDefaultGraphicsRHI : byte
	{
		DefaultGraphicsRHI_Default = 0,
		DefaultGraphicsRHI_DX11 = 1,
		DefaultGraphicsRHI_DX12 = 2,
		DefaultGraphicsRHI_Vulkan = 3,
	}
}