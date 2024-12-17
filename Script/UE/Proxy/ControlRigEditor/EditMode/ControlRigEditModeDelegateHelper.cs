using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigEditModeDelegateHelper")]
	public partial class UControlRigEditModeDelegateHelper : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigEditModeDelegateHelper");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void PostPoseUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PostPoseUpdate);
			}
		}

		public virtual void OnPoseInitialized()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnPoseInitialized);
			}
		}

		private static uint __PostPoseUpdate = 0;

		private static uint __OnPoseInitialized = 0;
	}
}