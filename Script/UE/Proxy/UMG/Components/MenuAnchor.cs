using Script.CoreUObject;
using Script.UMG.Widget;
using Script.UMG.MenuAnchor;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.MenuAnchor")]
	public partial class UMenuAnchor : UContentWidget, IStaticClass
	{
		public TSubclassOf<UUserWidget> MenuClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MenuClass, __ReturnBuffer);

					return *(TSubclassOf<UUserWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MenuClass, __InBuffer);
				}
			}
		}

		public FGetWidget OnGetMenuContentEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnGetMenuContentEvent, __ReturnBuffer);

					return *(FGetWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnGetMenuContentEvent, __InBuffer);
				}
			}
		}

		public FGetUserWidget OnGetUserMenuContentEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnGetUserMenuContentEvent, __ReturnBuffer);

					return *(FGetUserWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnGetUserMenuContentEvent, __InBuffer);
				}
			}
		}

		public EMenuPlacement Placement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Placement, __ReturnBuffer);

					return *(EMenuPlacement*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Placement, __InBuffer);
				}
			}
		}

		public bool bFitInWindow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFitInWindow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFitInWindow, __InBuffer);
				}
			}
		}

		public bool ShouldDeferPaintingAfterWindowContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShouldDeferPaintingAfterWindowContent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShouldDeferPaintingAfterWindowContent, __InBuffer);
				}
			}
		}

		public bool UseApplicationMenuStack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UseApplicationMenuStack, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UseApplicationMenuStack, __InBuffer);
				}
			}
		}

		public FOnMenuOpenChangedEvent OnMenuOpenChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMenuOpenChanged, __ReturnBuffer);

					return *(FOnMenuOpenChangedEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMenuOpenChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.MenuAnchor");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="bFocusOnOpen">
		/// Should we focus the popup as soon as it opens?
		/// </param>
		public virtual void ToggleOpen(bool bFocusOnOpen)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bFocusOnOpen;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleOpen, __InBuffer);
			}
		}

		public virtual bool ShouldOpenDueToClick()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ShouldOpenDueToClick, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetPlacement(EMenuPlacement InPlacement)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InPlacement;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlacement, __InBuffer);
			}
		}

		public virtual void Open(bool bFocusMenu)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bFocusMenu;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Open, __InBuffer);
			}
		}

		public virtual bool IsOpen()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsOpen, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasOpenSubMenus()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasOpenSubMenus, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetMenuPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMenuPosition, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual void FitInWindow(bool bFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FitInWindow, __InBuffer);
			}
		}

		public virtual void Close()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Close);
			}
		}

		private static uint __MenuClass = 0;

		private static uint __OnGetMenuContentEvent = 0;

		private static uint __OnGetUserMenuContentEvent = 0;

		private static uint __Placement = 0;

		private static uint __bFitInWindow = 0;

		private static uint __ShouldDeferPaintingAfterWindowContent = 0;

		private static uint __UseApplicationMenuStack = 0;

		private static uint __OnMenuOpenChanged = 0;

		private static uint __ToggleOpen = 0;

		private static uint __ShouldOpenDueToClick = 0;

		private static uint __SetPlacement = 0;

		private static uint __Open = 0;

		private static uint __IsOpen = 0;

		private static uint __HasOpenSubMenus = 0;

		private static uint __GetMenuPosition = 0;

		private static uint __FitInWindow = 0;

		private static uint __Close = 0;
	}
}