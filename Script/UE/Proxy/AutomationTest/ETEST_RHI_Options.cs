using Script.CoreUObject;

namespace Script.AutomationTest
{
	[PathName("/Script/AutomationTest.ETEST_RHI_Options")]
	public enum ETEST_RHI_Options : long
	{
		DirectX11 = 0,
		DirectX12 = 1,
		Vulkan = 2,
		Metal = 3,
		Null = 4,
	}
}