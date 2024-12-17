using Script.CoreUObject;
using Script.FieldNotification;
using Script.UMG.Widget;
using Script.SlateCore;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.Widget")]
	public partial class UWidget : UVisual, IStaticClass, INotifyFieldValueChanged
	{
		public UPanelSlot Slot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Slot, __ReturnBuffer);

					return *(UPanelSlot*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Slot, __InBuffer);
				}
			}
		}

		public FGetBool bIsEnabledDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledDelegate, __ReturnBuffer);

					return *(FGetBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledDelegate, __InBuffer);
				}
			}
		}

		public FText ToolTipText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipText, __InBuffer);
				}
			}
		}

		public FGetText ToolTipTextDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipTextDelegate, __ReturnBuffer);

					return *(FGetText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipTextDelegate, __InBuffer);
				}
			}
		}

		public UWidget ToolTipWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipWidget, __ReturnBuffer);

					return *(UWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipWidget, __InBuffer);
				}
			}
		}

		public FGetWidget ToolTipWidgetDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipWidgetDelegate, __ReturnBuffer);

					return *(FGetWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTipWidgetDelegate, __InBuffer);
				}
			}
		}

		public FGetSlateVisibility VisibilityDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VisibilityDelegate, __ReturnBuffer);

					return *(FGetSlateVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VisibilityDelegate, __InBuffer);
				}
			}
		}

		public FWidgetTransform RenderTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTransform, __ReturnBuffer);

					return *(FWidgetTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTransform, __InBuffer);
				}
			}
		}

		public FVector2D RenderTransformPivot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTransformPivot, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTransformPivot, __InBuffer);
				}
			}
		}

		public EFlowDirectionPreference FlowDirectionPreference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FlowDirectionPreference, __ReturnBuffer);

					return *(EFlowDirectionPreference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FlowDirectionPreference, __InBuffer);
				}
			}
		}

		public bool bIsVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVariable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVariable, __InBuffer);
				}
			}
		}

		public bool bCreatedByConstructionScript
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCreatedByConstructionScript, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCreatedByConstructionScript, __InBuffer);
				}
			}
		}

		public bool bIsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __InBuffer);
				}
			}
		}

		public bool bOverride_Cursor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverride_Cursor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverride_Cursor, __InBuffer);
				}
			}
		}

		public bool bOverrideAccessibleDefaults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAccessibleDefaults, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAccessibleDefaults, __InBuffer);
				}
			}
		}

		public bool bCanChildrenBeAccessible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanChildrenBeAccessible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanChildrenBeAccessible, __InBuffer);
				}
			}
		}

		public ESlateAccessibleBehavior AccessibleBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleBehavior, __ReturnBuffer);

					return *(ESlateAccessibleBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleBehavior, __InBuffer);
				}
			}
		}

		public ESlateAccessibleBehavior AccessibleSummaryBehavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleSummaryBehavior, __ReturnBuffer);

					return *(ESlateAccessibleBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleSummaryBehavior, __InBuffer);
				}
			}
		}

		public FText AccessibleText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleText, __InBuffer);
				}
			}
		}

		public FGetText AccessibleTextDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleTextDelegate, __ReturnBuffer);

					return *(FGetText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleTextDelegate, __InBuffer);
				}
			}
		}

		public FText AccessibleSummaryText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleSummaryText, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleSummaryText, __InBuffer);
				}
			}
		}

		public FGetText AccessibleSummaryTextDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleSummaryTextDelegate, __ReturnBuffer);

					return *(FGetText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleSummaryTextDelegate, __InBuffer);
				}
			}
		}

		public bool bIsVolatile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVolatile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsVolatile, __InBuffer);
				}
			}
		}

		public bool bHiddenInDesigner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenInDesigner, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHiddenInDesigner, __InBuffer);
				}
			}
		}

		public bool bExpandedInDesigner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExpandedInDesigner, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExpandedInDesigner, __InBuffer);
				}
			}
		}

		public bool bLockedInDesigner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLockedInDesigner, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLockedInDesigner, __InBuffer);
				}
			}
		}

		public EMouseCursor Cursor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Cursor, __ReturnBuffer);

					return *(EMouseCursor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Cursor, __InBuffer);
				}
			}
		}

		public EWidgetClipping Clipping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Clipping, __ReturnBuffer);

					return *(EWidgetClipping*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Clipping, __InBuffer);
				}
			}
		}

		public ESlateVisibility Visibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Visibility, __ReturnBuffer);

					return *(ESlateVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Visibility, __InBuffer);
				}
			}
		}

		public float RenderOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderOpacity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderOpacity, __InBuffer);
				}
			}
		}

		public EWidgetPixelSnapping PixelSnapping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PixelSnapping, __ReturnBuffer);

					return *(EWidgetPixelSnapping*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PixelSnapping, __InBuffer);
				}
			}
		}

		public USlateAccessibleWidgetData AccessibleWidgetData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleWidgetData, __ReturnBuffer);

					return *(USlateAccessibleWidgetData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccessibleWidgetData, __InBuffer);
				}
			}
		}

		public UWidgetNavigation Navigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Navigation, __ReturnBuffer);

					return *(UWidgetNavigation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Navigation, __InBuffer);
				}
			}
		}

		public TArray<UPropertyBinding> NativeBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NativeBindings, __ReturnBuffer);

					return *(TArray<UPropertyBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NativeBindings, __InBuffer);
				}
			}
		}

		public byte DesignerFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesignerFlags, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesignerFlags, __InBuffer);
				}
			}
		}

		public FString DisplayLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayLabel, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayLabel, __InBuffer);
				}
			}
		}

		public FString CategoryName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CategoryName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CategoryName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.Widget");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetVisibility(ESlateVisibility InVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisibility, __InBuffer);
			}
		}

		public virtual void SetUserFocus(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUserFocus, __InBuffer);
			}
		}

		public virtual void SetToolTipText(FText InToolTipText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InToolTipText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetToolTipText, __InBuffer);
			}
		}

		public virtual void SetToolTip(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetToolTip, __InBuffer);
			}
		}

		public virtual void SetRenderTranslation(FVector2D Translation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Translation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderTranslation, __InBuffer);
			}
		}

		public virtual void SetRenderTransformPivot(FVector2D Pivot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pivot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderTransformPivot, __InBuffer);
			}
		}

		public virtual void SetRenderTransformAngle(float Angle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Angle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderTransformAngle, __InBuffer);
			}
		}

		public virtual void SetRenderTransform(FWidgetTransform InTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderTransform, __InBuffer);
			}
		}

		public virtual void SetRenderShear(FVector2D Shear)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Shear?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderShear, __InBuffer);
			}
		}

		public virtual void SetRenderScale(FVector2D Scale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderScale, __InBuffer);
			}
		}

		public virtual void SetRenderOpacity(float InOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InOpacity;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderOpacity, __InBuffer);
			}
		}

		/// <param name="Direction">
		/// </param>
		/// <param name="InWidget">
		/// Focus on this widget instance
		/// </param>
		public virtual void SetNavigationRuleExplicit(EUINavigation Direction, UWidget InWidget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Direction;

				*(nint*)(__InBuffer + 1) = InWidget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationRuleExplicit, __InBuffer);
			}
		}

		/// <param name="Direction">
		/// </param>
		/// <param name="InCustomDelegate">
		/// Custom Delegate that will be called
		/// </param>
		public virtual void SetNavigationRuleCustomBoundary(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Direction;

				*(nint*)(__InBuffer + 1) = InCustomDelegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationRuleCustomBoundary, __InBuffer);
			}
		}

		/// <param name="Direction">
		/// </param>
		/// <param name="InCustomDelegate">
		/// Custom Delegate that will be called
		/// </param>
		public virtual void SetNavigationRuleCustom(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Direction;

				*(nint*)(__InBuffer + 1) = InCustomDelegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationRuleCustom, __InBuffer);
			}
		}

		/// <param name="Direction">
		/// </param>
		/// <param name="Rule">
		/// The rule to use when navigation is taking place
		/// </param>
		public virtual void SetNavigationRuleBase(EUINavigation Direction, EUINavigationRule Rule)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)Direction;

				*(byte*)(__InBuffer + 1) = (byte)Rule;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationRuleBase, __InBuffer);
			}
		}

		public virtual void SetNavigationRule(EUINavigation Direction, EUINavigationRule Rule, FName WidgetToFocus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(byte*)(__InBuffer) = (byte)Direction;

				*(byte*)(__InBuffer + 1) = (byte)Rule;

				*(nint*)(__InBuffer + 2) = WidgetToFocus?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNavigationRule, __InBuffer);
			}
		}

		public virtual void SetKeyboardFocus()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetKeyboardFocus);
			}
		}

		public virtual void SetIsEnabled(bool bInIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInIsEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsEnabled, __InBuffer);
			}
		}

		public virtual void SetFocus()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetFocus);
			}
		}

		public virtual void SetCursor(EMouseCursor InCursor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InCursor;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCursor, __InBuffer);
			}
		}

		public virtual void SetClipping(EWidgetClipping InClipping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InClipping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetClipping, __InBuffer);
			}
		}

		/// <param name="Rule">
		/// The rule to use when navigation is taking place
		/// </param>
		/// <param name="WidgetToFocus">
		/// When using the Explicit rule, focus on this widget
		/// </param>
		public virtual void SetAllNavigationRules(EUINavigationRule Rule, FName WidgetToFocus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Rule;

				*(nint*)(__InBuffer + 1) = WidgetToFocus?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllNavigationRules, __InBuffer);
			}
		}

		public virtual void ResetCursor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetCursor);
			}
		}

		public virtual void RemoveFromParent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveFromParent);
			}
		}

		public virtual void K2_RemoveFieldValueChangedDelegate(FFieldNotificationId FieldId, FFieldValueChangedDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = FieldId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_RemoveFieldValueChangedDelegate, __InBuffer);
			}
		}

		public virtual void K2_BroadcastFieldValueChanged(FFieldNotificationId FieldId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FieldId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_BroadcastFieldValueChanged, __InBuffer);
			}
		}

		public virtual void K2_AddFieldValueChangedDelegate(FFieldNotificationId FieldId, FFieldValueChangedDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = FieldId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_AddFieldValueChangedDelegate, __InBuffer);
			}
		}

		public virtual bool IsVisible()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsVisible, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsRendered()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRendered, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the widget was added to the viewport using AddToViewport or AddToPlayerScreen. */
		/// </returns>
		public virtual bool IsInViewport()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInViewport, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsHovered()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHovered, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void InvalidateLayoutAndVolatility()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __InvalidateLayoutAndVolatility);
			}
		}

		public virtual bool HasUserFocusedDescendants(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasUserFocusedDescendants, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasUserFocus(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasUserFocus, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="User">
		/// index to check for capture
		/// </param>
		/// <param name="Optional">
		/// pointer index to check for capture
		/// </param>
		/// <returns>
		/// True if this widget has captured the mouse with given user and pointer
		/// </returns>
		public virtual bool HasMouseCaptureByUser(int UserIndex, int PointerIndex = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = UserIndex;

				*(int*)(__InBuffer + 4) = PointerIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasMouseCaptureByUser, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if this widget has captured the mouse
		/// </returns>
		public virtual bool HasMouseCapture()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasMouseCapture, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if this widget has keyboard focus
		/// </returns>
		public virtual bool HasKeyboardFocus()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasKeyboardFocus, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasFocusedDescendants()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasFocusedDescendants, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasAnyUserFocus()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasAnyUserFocus, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual ESlateVisibility GetVisibility()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVisibility, __ReturnBuffer);

				return *(ESlateVisibility*)__ReturnBuffer;
			}
		}

		public virtual FGeometry GetTickSpaceGeometry()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTickSpaceGeometry, __ReturnBuffer);

				return *(FGeometry*)__ReturnBuffer;
			}
		}

		public virtual float GetRenderTransformAngle()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRenderTransformAngle, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRenderOpacity()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRenderOpacity, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UPanelWidget GetParent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParent, __ReturnBuffer);

				return *(UPanelWidget*)__ReturnBuffer;
			}
		}

		public virtual FGeometry GetPaintSpaceGeometry()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPaintSpaceGeometry, __ReturnBuffer);

				return *(FGeometry*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The player controller that owns the UI.
		/// </returns>
		public virtual APlayerController GetOwningPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningPlayer, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The owning local player.
		/// </returns>
		public virtual ULocalPlayer GetOwningLocalPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningLocalPlayer, __ReturnBuffer);

				return *(ULocalPlayer*)__ReturnBuffer;
			}
		}

		public virtual bool GetIsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetIsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// a pointer to the owning game instance
		/// </returns>
		public virtual UGameInstance GetGameInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGameInstance, __ReturnBuffer);

				return *(UGameInstance*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The widget's desired size
		/// </returns>
		public virtual FVector2D GetDesiredSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDesiredSize, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual EWidgetClipping GetClipping()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetClipping, __ReturnBuffer);

				return *(EWidgetClipping*)__ReturnBuffer;
			}
		}

		public virtual FGeometry GetCachedGeometry()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCachedGeometry, __ReturnBuffer);

				return *(FGeometry*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The accessible text of the underlying Slate accessible widget. Returns an empty text if
		/// accessibility is dsabled or the underlying accessible widget is invalid.
		/// </returns>
		public virtual FText GetAccessibleText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAccessibleText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The accessible summary text of the underlying Slate accessible widget. Returns an empty text if
		/// accessibility is dsabled or the underlying accessible widget is invalid.
		/// </returns>
		public virtual FText GetAccessibleSummaryText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAccessibleSummaryText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual void ForceVolatile(bool bForce)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bForce;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ForceVolatile, __InBuffer);
			}
		}

		public virtual void ForceLayoutPrepass()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForceLayoutPrepass);
			}
		}

		private static uint __Slot = 0;

		private static uint __bIsEnabledDelegate = 0;

		private static uint __ToolTipText = 0;

		private static uint __ToolTipTextDelegate = 0;

		private static uint __ToolTipWidget = 0;

		private static uint __ToolTipWidgetDelegate = 0;

		private static uint __VisibilityDelegate = 0;

		private static uint __RenderTransform = 0;

		private static uint __RenderTransformPivot = 0;

		private static uint __FlowDirectionPreference = 0;

		private static uint __bIsVariable = 0;

		private static uint __bCreatedByConstructionScript = 0;

		private static uint __bIsEnabled = 0;

		private static uint __bOverride_Cursor = 0;

		private static uint __bOverrideAccessibleDefaults = 0;

		private static uint __bCanChildrenBeAccessible = 0;

		private static uint __AccessibleBehavior = 0;

		private static uint __AccessibleSummaryBehavior = 0;

		private static uint __AccessibleText = 0;

		private static uint __AccessibleTextDelegate = 0;

		private static uint __AccessibleSummaryText = 0;

		private static uint __AccessibleSummaryTextDelegate = 0;

		private static uint __bIsVolatile = 0;

		private static uint __bHiddenInDesigner = 0;

		private static uint __bExpandedInDesigner = 0;

		private static uint __bLockedInDesigner = 0;

		private static uint __Cursor = 0;

		private static uint __Clipping = 0;

		private static uint __Visibility = 0;

		private static uint __RenderOpacity = 0;

		private static uint __PixelSnapping = 0;

		private static uint __AccessibleWidgetData = 0;

		private static uint __Navigation = 0;

		private static uint __NativeBindings = 0;

		private static uint __DesignerFlags = 0;

		private static uint __DisplayLabel = 0;

		private static uint __CategoryName = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetVisibility = 0;

		private static uint __SetUserFocus = 0;

		private static uint __SetToolTipText = 0;

		private static uint __SetToolTip = 0;

		private static uint __SetRenderTranslation = 0;

		private static uint __SetRenderTransformPivot = 0;

		private static uint __SetRenderTransformAngle = 0;

		private static uint __SetRenderTransform = 0;

		private static uint __SetRenderShear = 0;

		private static uint __SetRenderScale = 0;

		private static uint __SetRenderOpacity = 0;

		private static uint __SetNavigationRuleExplicit = 0;

		private static uint __SetNavigationRuleCustomBoundary = 0;

		private static uint __SetNavigationRuleCustom = 0;

		private static uint __SetNavigationRuleBase = 0;

		private static uint __SetNavigationRule = 0;

		private static uint __SetKeyboardFocus = 0;

		private static uint __SetIsEnabled = 0;

		private static uint __SetFocus = 0;

		private static uint __SetCursor = 0;

		private static uint __SetClipping = 0;

		private static uint __SetAllNavigationRules = 0;

		private static uint __ResetCursor = 0;

		private static uint __RemoveFromParent = 0;

		private static uint __K2_RemoveFieldValueChangedDelegate = 0;

		private static uint __K2_BroadcastFieldValueChanged = 0;

		private static uint __K2_AddFieldValueChangedDelegate = 0;

		private static uint __IsVisible = 0;

		private static uint __IsRendered = 0;

		private static uint __IsInViewport = 0;

		private static uint __IsHovered = 0;

		private static uint __InvalidateLayoutAndVolatility = 0;

		private static uint __HasUserFocusedDescendants = 0;

		private static uint __HasUserFocus = 0;

		private static uint __HasMouseCaptureByUser = 0;

		private static uint __HasMouseCapture = 0;

		private static uint __HasKeyboardFocus = 0;

		private static uint __HasFocusedDescendants = 0;

		private static uint __HasAnyUserFocus = 0;

		private static uint __GetVisibility = 0;

		private static uint __GetTickSpaceGeometry = 0;

		private static uint __GetRenderTransformAngle = 0;

		private static uint __GetRenderOpacity = 0;

		private static uint __GetParent = 0;

		private static uint __GetPaintSpaceGeometry = 0;

		private static uint __GetOwningPlayer = 0;

		private static uint __GetOwningLocalPlayer = 0;

		private static uint __GetIsEnabled = 0;

		private static uint __GetGameInstance = 0;

		private static uint __GetDesiredSize = 0;

		private static uint __GetClipping = 0;

		private static uint __GetCachedGeometry = 0;

		private static uint __GetAccessibleText = 0;

		private static uint __GetAccessibleSummaryText = 0;

		private static uint __ForceVolatile = 0;

		private static uint __ForceLayoutPrepass = 0;
	}
}