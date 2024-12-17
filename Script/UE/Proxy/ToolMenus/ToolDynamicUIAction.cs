using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolDynamicUIAction")]
	public partial class FToolDynamicUIAction : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ToolMenus.ToolDynamicUIAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FToolDynamicUIAction() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FToolDynamicUIAction() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FToolDynamicUIAction A, FToolDynamicUIAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FToolDynamicUIAction A, FToolDynamicUIAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FToolDynamicUIAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FToolMenuDynamicExecuteAction ExecuteAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExecuteAction, __ReturnBuffer);

					return *(FToolMenuDynamicExecuteAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExecuteAction, __InBuffer);
				}
			}
		}

		public FToolMenuDynamicCanExecuteAction CanExecuteAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CanExecuteAction, __ReturnBuffer);

					return *(FToolMenuDynamicCanExecuteAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CanExecuteAction, __InBuffer);
				}
			}
		}

		public FToolMenuDynamicGetActionCheckState GetActionCheckState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GetActionCheckState, __ReturnBuffer);

					return *(FToolMenuDynamicGetActionCheckState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GetActionCheckState, __InBuffer);
				}
			}
		}

		public FToolMenuDynamicIsActionButtonVisible IsActionVisibleDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IsActionVisibleDelegate, __ReturnBuffer);

					return *(FToolMenuDynamicIsActionButtonVisible*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IsActionVisibleDelegate, __InBuffer);
				}
			}
		}

		private static uint __ExecuteAction = 0;

		private static uint __CanExecuteAction = 0;

		private static uint __GetActionCheckState = 0;

		private static uint __IsActionVisibleDelegate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}