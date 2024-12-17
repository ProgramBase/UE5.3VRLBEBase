using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKGoalCreatorInterface")]
	public partial class UIKGoalCreatorInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRig.IKGoalCreatorInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/IKRig.IKGoalCreatorInterface")]
	public interface IIKGoalCreatorInterface : IInterface
	{
		 void AddIKGoals(ref TMap<FName, FIKRigGoal> OutGoals);
	}
}