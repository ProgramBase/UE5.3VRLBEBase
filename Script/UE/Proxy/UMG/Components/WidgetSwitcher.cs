using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetSwitcher")]
	public partial class UWidgetSwitcher : UPanelWidget, IStaticClass
	{
		public int ActiveWidgetIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveWidgetIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveWidgetIndex, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetSwitcher");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetActiveWidgetIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActiveWidgetIndex, __InBuffer);
			}
		}

		public virtual void SetActiveWidget(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActiveWidget, __InBuffer);
			}
		}

		public virtual UWidget GetWidgetAtIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWidgetAtIndex, __InBuffer, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}

		public virtual int GetNumWidgets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumWidgets, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetActiveWidgetIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetActiveWidgetIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UWidget GetActiveWidget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActiveWidget, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}

		private static uint __ActiveWidgetIndex = 0;

		private static uint __SetActiveWidgetIndex = 0;

		private static uint __SetActiveWidget = 0;

		private static uint __GetWidgetAtIndex = 0;

		private static uint __GetNumWidgets = 0;

		private static uint __GetActiveWidgetIndex = 0;

		private static uint __GetActiveWidget = 0;
	}
}