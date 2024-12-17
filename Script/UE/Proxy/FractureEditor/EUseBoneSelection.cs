using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EUseBoneSelection")]
	public enum EUseBoneSelection : int
	{
		NoEffect = 0,
		AlsoMergeSelected = 1,
		OnlyMergeSelected = 2,
	}
}