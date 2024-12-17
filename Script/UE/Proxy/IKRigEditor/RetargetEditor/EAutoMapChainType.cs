using Script.CoreUObject;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.EAutoMapChainType")]
	public enum EAutoMapChainType : byte
	{
		Exact = 0,
		Fuzzy = 1,
		Clear = 2,
	}
}