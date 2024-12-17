using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERBFKernelType")]
	public enum ERBFKernelType : byte
	{
		Gaussian = 0,
		Exponential = 1,
		Linear = 2,
		Cubic = 3,
		Quintic = 4,
	}
}