using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetComponent")]
	public partial class UWidgetComponent : UMeshComponent, IStaticClass
	{
		public EWidgetSpace Space
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Space, __ReturnBuffer);

					return *(EWidgetSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Space, __InBuffer);
				}
			}
		}

		public EWidgetTimingPolicy TimingPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimingPolicy, __ReturnBuffer);

					return *(EWidgetTimingPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimingPolicy, __InBuffer);
				}
			}
		}

		public TSubclassOf<UUserWidget> WidgetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetClass, __ReturnBuffer);

					return *(TSubclassOf<UUserWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetClass, __InBuffer);
				}
			}
		}

		public FIntPoint DrawSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawSize, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawSize, __InBuffer);
				}
			}
		}

		public bool bManuallyRedraw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bManuallyRedraw, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bManuallyRedraw, __InBuffer);
				}
			}
		}

		public bool bRedrawRequested
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRedrawRequested, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRedrawRequested, __InBuffer);
				}
			}
		}

		public float RedrawTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RedrawTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RedrawTime, __InBuffer);
				}
			}
		}

		public FIntPoint CurrentDrawSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentDrawSize, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentDrawSize, __InBuffer);
				}
			}
		}

		public bool bDrawAtDesiredSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawAtDesiredSize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawAtDesiredSize, __InBuffer);
				}
			}
		}

		public FVector2D Pivot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Pivot, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Pivot, __InBuffer);
				}
			}
		}

		public bool bReceiveHardwareInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReceiveHardwareInput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReceiveHardwareInput, __InBuffer);
				}
			}
		}

		public bool bWindowFocusable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWindowFocusable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWindowFocusable, __InBuffer);
				}
			}
		}

		public EWindowVisibility WindowVisibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WindowVisibility, __ReturnBuffer);

					return *(EWindowVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WindowVisibility, __InBuffer);
				}
			}
		}

		public bool bApplyGammaCorrection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyGammaCorrection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bApplyGammaCorrection, __InBuffer);
				}
			}
		}

		public ULocalPlayer OwnerPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerPlayer, __ReturnBuffer);

					return *(ULocalPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerPlayer, __InBuffer);
				}
			}
		}

		public FLinearColor BackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __InBuffer);
				}
			}
		}

		public FLinearColor TintColorAndOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TintColorAndOpacity, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TintColorAndOpacity, __InBuffer);
				}
			}
		}

		public float OpacityFromTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OpacityFromTexture, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OpacityFromTexture, __InBuffer);
				}
			}
		}

		public EWidgetBlendMode BlendMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendMode, __ReturnBuffer);

					return *(EWidgetBlendMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendMode, __InBuffer);
				}
			}
		}

		public bool bIsTwoSided
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsTwoSided, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsTwoSided, __InBuffer);
				}
			}
		}

		public bool TickWhenOffscreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickWhenOffscreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickWhenOffscreen, __InBuffer);
				}
			}
		}

		public UBodySetup BodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __InBuffer);
				}
			}
		}

		public UMaterialInterface TranslucentMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface TranslucentMaterial_OneSided
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentMaterial_OneSided, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TranslucentMaterial_OneSided, __InBuffer);
				}
			}
		}

		public UMaterialInterface OpaqueMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OpaqueMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OpaqueMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface OpaqueMaterial_OneSided
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OpaqueMaterial_OneSided, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OpaqueMaterial_OneSided, __InBuffer);
				}
			}
		}

		public UMaterialInterface MaskedMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaskedMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaskedMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface MaskedMaterial_OneSided
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaskedMaterial_OneSided, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaskedMaterial_OneSided, __InBuffer);
				}
			}
		}

		public UTextureRenderTarget2D RenderTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTarget, __ReturnBuffer);

					return *(UTextureRenderTarget2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderTarget, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic MaterialInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialInstance, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialInstance, __InBuffer);
				}
			}
		}

		public bool bAddedToScreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAddedToScreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAddedToScreen, __InBuffer);
				}
			}
		}

		public bool bEditTimeUsable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEditTimeUsable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEditTimeUsable, __InBuffer);
				}
			}
		}

		public FName SharedLayerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SharedLayerName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SharedLayerName, __InBuffer);
				}
			}
		}

		public int LayerZOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LayerZOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LayerZOrder, __InBuffer);
				}
			}
		}

		public EWidgetGeometryMode GeometryMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryMode, __ReturnBuffer);

					return *(EWidgetGeometryMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryMode, __InBuffer);
				}
			}
		}

		public float CylinderArcAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CylinderArcAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CylinderArcAngle, __InBuffer);
				}
			}
		}

		public ETickMode TickMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickMode, __ReturnBuffer);

					return *(ETickMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickMode, __InBuffer);
				}
			}
		}

		public UUserWidget Widget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Widget, __ReturnBuffer);

					return *(UUserWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Widget, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWindowVisibility(EWindowVisibility InVisibility)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVisibility;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWindowVisibility, __InBuffer);
			}
		}

		/// <see>
		/// bWindowFocusable */
		/// </see>
		public virtual void SetWindowFocusable(bool bInWindowFocusable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInWindowFocusable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWindowFocusable, __InBuffer);
			}
		}

		public virtual void SetWidgetSpace(EWidgetSpace NewSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewSpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWidgetSpace, __InBuffer);
			}
		}

		public virtual void SetWidget(UUserWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWidget, __InBuffer);
			}
		}

		public virtual void SetTwoSided(bool bWantTwoSided)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bWantTwoSided;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTwoSided, __InBuffer);
			}
		}

		public virtual void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTintColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTintColorAndOpacity, __InBuffer);
			}
		}

		public virtual void SetTickWhenOffscreen(bool bWantTickWhenOffscreen)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bWantTickWhenOffscreen;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTickWhenOffscreen, __InBuffer);
			}
		}

		public virtual void SetTickMode(ETickMode InTickMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InTickMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTickMode, __InBuffer);
			}
		}

		public virtual void SetRedrawTime(float InRedrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InRedrawTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRedrawTime, __InBuffer);
			}
		}

		public virtual void SetPivot(FVector2D InPivot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPivot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPivot, __InBuffer);
			}
		}

		public virtual void SetOwnerPlayer(ULocalPlayer LocalPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LocalPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOwnerPlayer, __InBuffer);
			}
		}

		/// <see>
		/// bManuallyRedraw */
		/// </see>
		public virtual void SetManuallyRedraw(bool bUseManualRedraw)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bUseManualRedraw;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetManuallyRedraw, __InBuffer);
			}
		}

		public virtual void SetGeometryMode(EWidgetGeometryMode InGeometryMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InGeometryMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGeometryMode, __InBuffer);
			}
		}

		public virtual void SetDrawSize(FVector2D Size)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Size?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDrawSize, __InBuffer);
			}
		}

		public virtual void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInDrawAtDesiredSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDrawAtDesiredSize, __InBuffer);
			}
		}

		public virtual void SetCylinderArcAngle(float InCylinderArcAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InCylinderArcAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCylinderArcAngle, __InBuffer);
			}
		}

		public virtual void SetBackgroundColor(FLinearColor NewBackgroundColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewBackgroundColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBackgroundColor, __InBuffer);
			}
		}

		public virtual void RequestRenderUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestRenderUpdate);
			}
		}

		public virtual void RequestRedraw()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestRedraw);
			}
		}

		public virtual bool IsWidgetVisible()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsWidgetVisible, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EWindowVisibility GetWindowVisiblility()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetWindowVisiblility, __ReturnBuffer);

				return *(EWindowVisibility*)__ReturnBuffer;
			}
		}

		/// <see>
		/// bWindowFocusable */
		/// </see>
		public virtual bool GetWindowFocusable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetWindowFocusable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EWidgetSpace GetWidgetSpace()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetWidgetSpace, __ReturnBuffer);

				return *(EWidgetSpace*)__ReturnBuffer;
			}
		}

		public virtual UUserWidget GetWidget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWidget, __ReturnBuffer);

				return *(UUserWidget*)__ReturnBuffer;
			}
		}

		public virtual UUserWidget GetUserWidgetObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUserWidgetObject, __ReturnBuffer);

				return *(UUserWidget*)__ReturnBuffer;
			}
		}

		public virtual bool GetTwoSided()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTwoSided, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetTickWhenOffscreen()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTickWhenOffscreen, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UTextureRenderTarget2D GetRenderTarget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRenderTarget, __ReturnBuffer);

				return *(UTextureRenderTarget2D*)__ReturnBuffer;
			}
		}

		public virtual float GetRedrawTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRedrawTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetPivot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPivot, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual ULocalPlayer GetOwnerPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwnerPlayer, __ReturnBuffer);

				return *(ULocalPlayer*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInstanceDynamic GetMaterialInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterialInstance, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		/// <see>
		/// bManuallyRedraw */
		/// </see>
		public virtual bool GetManuallyRedraw()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetManuallyRedraw, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// EWidgetGeometryMode, @see GetCylinderArcAngle() */
		/// </see>
		public virtual EWidgetGeometryMode GetGeometryMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGeometryMode, __ReturnBuffer);

				return *(EWidgetGeometryMode*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetDrawSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDrawSize, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual bool GetDrawAtDesiredSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDrawAtDesiredSize, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetCylinderArcAngle()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCylinderArcAngle, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetCurrentDrawSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentDrawSize, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		private static uint __Space = 0;

		private static uint __TimingPolicy = 0;

		private static uint __WidgetClass = 0;

		private static uint __DrawSize = 0;

		private static uint __bManuallyRedraw = 0;

		private static uint __bRedrawRequested = 0;

		private static uint __RedrawTime = 0;

		private static uint __CurrentDrawSize = 0;

		private static uint __bDrawAtDesiredSize = 0;

		private static uint __Pivot = 0;

		private static uint __bReceiveHardwareInput = 0;

		private static uint __bWindowFocusable = 0;

		private static uint __WindowVisibility = 0;

		private static uint __bApplyGammaCorrection = 0;

		private static uint __OwnerPlayer = 0;

		private static uint __BackgroundColor = 0;

		private static uint __TintColorAndOpacity = 0;

		private static uint __OpacityFromTexture = 0;

		private static uint __BlendMode = 0;

		private static uint __bIsTwoSided = 0;

		private static uint __TickWhenOffscreen = 0;

		private static uint __BodySetup = 0;

		private static uint __TranslucentMaterial = 0;

		private static uint __TranslucentMaterial_OneSided = 0;

		private static uint __OpaqueMaterial = 0;

		private static uint __OpaqueMaterial_OneSided = 0;

		private static uint __MaskedMaterial = 0;

		private static uint __MaskedMaterial_OneSided = 0;

		private static uint __RenderTarget = 0;

		private static uint __MaterialInstance = 0;

		private static uint __bAddedToScreen = 0;

		private static uint __bEditTimeUsable = 0;

		private static uint __SharedLayerName = 0;

		private static uint __LayerZOrder = 0;

		private static uint __GeometryMode = 0;

		private static uint __CylinderArcAngle = 0;

		private static uint __TickMode = 0;

		private static uint __Widget = 0;

		private static uint __SetWindowVisibility = 0;

		private static uint __SetWindowFocusable = 0;

		private static uint __SetWidgetSpace = 0;

		private static uint __SetWidget = 0;

		private static uint __SetTwoSided = 0;

		private static uint __SetTintColorAndOpacity = 0;

		private static uint __SetTickWhenOffscreen = 0;

		private static uint __SetTickMode = 0;

		private static uint __SetRedrawTime = 0;

		private static uint __SetPivot = 0;

		private static uint __SetOwnerPlayer = 0;

		private static uint __SetManuallyRedraw = 0;

		private static uint __SetGeometryMode = 0;

		private static uint __SetDrawSize = 0;

		private static uint __SetDrawAtDesiredSize = 0;

		private static uint __SetCylinderArcAngle = 0;

		private static uint __SetBackgroundColor = 0;

		private static uint __RequestRenderUpdate = 0;

		private static uint __RequestRedraw = 0;

		private static uint __IsWidgetVisible = 0;

		private static uint __GetWindowVisiblility = 0;

		private static uint __GetWindowFocusable = 0;

		private static uint __GetWidgetSpace = 0;

		private static uint __GetWidget = 0;

		private static uint __GetUserWidgetObject = 0;

		private static uint __GetTwoSided = 0;

		private static uint __GetTickWhenOffscreen = 0;

		private static uint __GetRenderTarget = 0;

		private static uint __GetRedrawTime = 0;

		private static uint __GetPivot = 0;

		private static uint __GetOwnerPlayer = 0;

		private static uint __GetMaterialInstance = 0;

		private static uint __GetManuallyRedraw = 0;

		private static uint __GetGeometryMode = 0;

		private static uint __GetDrawSize = 0;

		private static uint __GetDrawAtDesiredSize = 0;

		private static uint __GetCylinderArcAngle = 0;

		private static uint __GetCurrentDrawSize = 0;
	}
}