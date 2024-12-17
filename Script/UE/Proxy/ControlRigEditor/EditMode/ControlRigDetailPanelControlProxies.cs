using Script.CoreUObject;
using Script.ControlRig;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigDetailPanelControlProxies")]
	public partial class UControlRigDetailPanelControlProxies : UObject, IStaticClass
	{
		public TMap<UControlRig, FControlToProxyMap> AllProxies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllProxies, __ReturnBuffer);

					return *(TMap<UControlRig, FControlToProxyMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllProxies, __InBuffer);
				}
			}
		}

		public TArray<UControlRigControlsProxy> SelectedProxies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedProxies, __ReturnBuffer);

					return *(TArray<UControlRigControlsProxy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedProxies, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigDetailPanelControlProxies");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AllProxies = 0;

		private static uint __SelectedProxies = 0;
	}
}