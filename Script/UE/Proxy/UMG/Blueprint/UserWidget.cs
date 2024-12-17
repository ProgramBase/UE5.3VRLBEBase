using Script.CoreUObject;
using Script.UMG.Widget;
using Script.SlateCore;
using Script.Slate;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UserWidget")]
	public partial class UUserWidget : UWidget, IStaticClass, INamedSlotInterface
	{
		public FLinearColor ColorAndOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacity, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacity, __InBuffer);
				}
			}
		}

		public FGetLinearColor ColorAndOpacityDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacityDelegate, __ReturnBuffer);

					return *(FGetLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorAndOpacityDelegate, __InBuffer);
				}
			}
		}

		public FSlateColor ForegroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForegroundColor, __ReturnBuffer);

					return *(FSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForegroundColor, __InBuffer);
				}
			}
		}

		public FGetSlateColor ForegroundColorDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForegroundColorDelegate, __ReturnBuffer);

					return *(FGetSlateColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForegroundColorDelegate, __InBuffer);
				}
			}
		}

		public FOnVisibilityChangedEvent OnVisibilityChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnVisibilityChanged, __ReturnBuffer);

					return *(FOnVisibilityChangedEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnVisibilityChanged, __InBuffer);
				}
			}
		}

		public FMargin Padding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Padding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Padding, __InBuffer);
				}
			}
		}

		public int Priority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __InBuffer);
				}
			}
		}

		public bool bIsFocusable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFocusable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFocusable, __InBuffer);
				}
			}
		}

		public bool bStopAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStopAction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStopAction, __InBuffer);
				}
			}
		}

		public TArray<UUMGSequencePlayer> ActiveSequencePlayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveSequencePlayers, __ReturnBuffer);

					return *(TArray<UUMGSequencePlayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveSequencePlayers, __InBuffer);
				}
			}
		}

		public UUMGSequenceTickManager AnimationTickManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationTickManager, __ReturnBuffer);

					return *(UUMGSequenceTickManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationTickManager, __InBuffer);
				}
			}
		}

		public TArray<UUMGSequencePlayer> StoppedSequencePlayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StoppedSequencePlayers, __ReturnBuffer);

					return *(TArray<UUMGSequencePlayer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StoppedSequencePlayers, __InBuffer);
				}
			}
		}

		public TArray<FNamedSlotBinding> NamedSlotBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NamedSlotBindings, __ReturnBuffer);

					return *(TArray<FNamedSlotBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NamedSlotBindings, __InBuffer);
				}
			}
		}

		public TArray<UUserWidgetExtension> Extensions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Extensions, __ReturnBuffer);

					return *(TArray<UUserWidgetExtension>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Extensions, __InBuffer);
				}
			}
		}

		public UWidgetTree WidgetTree
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetTree, __ReturnBuffer);

					return *(UWidgetTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetTree, __InBuffer);
				}
			}
		}

		public FVector2D DesignTimeSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesignTimeSize, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesignTimeSize, __InBuffer);
				}
			}
		}

		public EDesignPreviewSizeMode DesignSizeMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesignSizeMode, __ReturnBuffer);

					return *(EDesignPreviewSizeMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesignSizeMode, __InBuffer);
				}
			}
		}

		public FText PaletteCategory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PaletteCategory, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PaletteCategory, __InBuffer);
				}
			}
		}

		public UTexture2D PreviewBackground
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewBackground, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewBackground, __InBuffer);
				}
			}
		}

		public bool bHasScriptImplementedTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasScriptImplementedTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasScriptImplementedTick, __InBuffer);
				}
			}
		}

		public bool bHasScriptImplementedPaint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasScriptImplementedPaint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasScriptImplementedPaint, __InBuffer);
				}
			}
		}

		public EWidgetTickFrequency TickFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickFrequency, __ReturnBuffer);

					return *(EWidgetTickFrequency*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickFrequency, __InBuffer);
				}
			}
		}

		public FWidgetChild DesiredFocusWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredFocusWidget, __ReturnBuffer);

					return *(FWidgetChild*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredFocusWidget, __InBuffer);
				}
			}
		}

		public UInputComponent InputComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputComponent, __ReturnBuffer);

					return *(UInputComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputComponent, __InBuffer);
				}
			}
		}

		public TArray<FAnimationEventBinding> AnimationCallbacks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationCallbacks, __ReturnBuffer);

					return *(TArray<FAnimationEventBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationCallbacks, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UserWidget");
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

		public virtual void UnregisterInputComponent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnregisterInputComponent);
			}
		}

		/// <param name="Animation">
		/// the animation to listen for starting or finishing.
		/// </param>
		/// <param name="Delegate">
		/// the delegate to call when the animation's state changes
		/// </param>
		public virtual void UnbindFromAnimationStarted(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindFromAnimationStarted, __InBuffer);
			}
		}

		/// <param name="Animation">
		/// the animation to listen for starting or finishing.
		/// </param>
		/// <param name="Delegate">
		/// the delegate to call when the animation's state changes
		/// </param>
		public virtual void UnbindFromAnimationFinished(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindFromAnimationFinished, __InBuffer);
			}
		}

		public virtual void UnbindAllFromAnimationStarted(UWidgetAnimation Animation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindAllFromAnimationStarted, __InBuffer);
			}
		}

		public virtual void UnbindAllFromAnimationFinished(UWidgetAnimation Animation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindAllFromAnimationFinished, __InBuffer);
			}
		}

		/// <param name="MyGeometry">
		/// The space allotted for this widget
		/// </param>
		/// <param name="InDeltaTime">
		/// Real time passed since last tick
		/// </param>
		public virtual void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InDeltaTime;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __Tick, __InBuffer);
			}
		}

		public virtual void StopListeningForInputAction(FName ActionName, EInputEvent EventType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ActionName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EventType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopListeningForInputAction, __InBuffer);
			}
		}

		public virtual void StopListeningForAllInputActions()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopListeningForAllInputActions);
			}
		}

		public virtual void StopAnimationsAndLatentActions()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopAnimationsAndLatentActions);
			}
		}

		/// <param name="The">
		/// name of the animation to stop
		/// </param>
		public virtual void StopAnimation(UWidgetAnimation InAnimation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAnimation, __InBuffer);
			}
		}

		/// <param name="The">
		/// name of the animation to stop
		/// </param>
		public virtual void StopAllAnimations()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopAllAnimations);
			}
		}

		/// <param name="Position">
		/// The 2D position to set the widget to in the viewport.
		/// </param>
		/// <param name="bRemoveDPIScale">
		/// If you've already calculated inverse DPI, set this to false.  
		/// Otherwise inverse DPI is applied to the position so that when the location is scaled 
		/// by DPI, it ends up in the expected position.
		/// </param>
		public virtual void SetPositionInViewport(FVector2D Position, bool bRemoveDPIScale = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bRemoveDPIScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionInViewport, __InBuffer);
			}
		}

		/// <param name="InAnimation">
		/// The animation that is already playing
		/// </param>
		/// <param name="PlaybackRate">
		/// Playback rate multiplier (1 is default)
		/// </param>
		public virtual void SetPlaybackSpeed(UWidgetAnimation InAnimation, float PlaybackSpeed = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PlaybackSpeed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaybackSpeed, __InBuffer);
			}
		}

		public virtual void SetPadding(FMargin InPadding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPadding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPadding, __InBuffer);
			}
		}

		/// <param name="LocalPlayerController">
		/// The PlayerController of the local player you want to be the conceptual owner of this UI.
		/// </param>
		public virtual void SetOwningPlayer(APlayerController LocalPlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LocalPlayerController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOwningPlayer, __InBuffer);
			}
		}

		/// <param name="InAnimation">
		/// The animation that is already playing
		/// </param>
		/// <param name="NumLoopsToPlay">
		/// The number of loops to play. (0 to loop indefinitely)
		/// </param>
		public virtual void SetNumLoopsToPlay(UWidgetAnimation InAnimation, int NumLoopsToPlay)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NumLoopsToPlay;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumLoopsToPlay, __InBuffer);
			}
		}

		public virtual void SetInputActionPriority(int NewPriority)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NewPriority;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInputActionPriority, __InBuffer);
			}
		}

		public virtual void SetInputActionBlocking(bool bShouldBlock)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShouldBlock;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInputActionBlocking, __InBuffer);
			}
		}

		/// <param name="InForegroundColor">
		/// The foreground color.
		/// </param>
		public virtual void SetForegroundColor(FSlateColor InForegroundColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InForegroundColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForegroundColor, __InBuffer);
			}
		}

		public virtual void SetDesiredSizeInViewport(FVector2D Size)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Size?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDesiredSizeInViewport, __InBuffer);
			}
		}

		/// <param name="InColorAndOpacity">
		/// The tint to apply to all child widgets.
		/// </param>
		public virtual void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColorAndOpacity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColorAndOpacity, __InBuffer);
			}
		}

		/// <param name="The">
		/// name of the animation to get the current time for
		/// </param>
		/// <param name="The">
		/// current time of the animation.
		/// </param>
		public virtual void SetAnimationCurrentTime(UWidgetAnimation InAnimation, float InTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimationCurrentTime, __InBuffer);
			}
		}

		public virtual void SetAnchorsInViewport(FAnchors Anchors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Anchors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnchorsInViewport, __InBuffer);
			}
		}

		public virtual void SetAlignmentInViewport(FVector2D Alignment)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Alignment?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAlignmentInViewport, __InBuffer);
			}
		}

		/// <param name="InAnimation">
		/// The playing animation that we want to reverse
		/// </param>
		public virtual void ReverseAnimation(UWidgetAnimation InAnimation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReverseAnimation, __InBuffer);
			}
		}

		public virtual void RemoveFromViewport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveFromViewport);
			}
		}

		public virtual void RemoveExtensions(TSubclassOf<UUserWidgetExtension> InExtensionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InExtensionType?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveExtensions, __InBuffer);
			}
		}

		public virtual void RemoveExtension(UUserWidgetExtension InExtension)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InExtension?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveExtension, __InBuffer);
			}
		}

		public virtual void RegisterInputComponent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RegisterInputComponent);
			}
		}

		public virtual void PreConstruct(bool IsDesignTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = IsDesignTime;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __PreConstruct, __InBuffer);
			}
		}

		/// <param name="The">
		/// sound to play
		/// </param>
		public virtual void PlaySound(USoundBase SoundToPlay)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoundToPlay?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlaySound, __InBuffer);
			}
		}

		/// <param name="InAnimation">
		/// The animation to play
		/// </param>
		/// <param name="StartAtTime">
		/// The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
		/// </param>
		/// <param name="EndAtTime">
		/// The absolute time in the animation where to stop, this is only considered in the last loop.
		/// </param>
		/// <param name="NumLoopsToPlay">
		/// The number of times to loop this animation (0 to loop indefinitely)
		/// </param>
		/// <param name="PlayMode">
		/// Specifies the playback mode
		/// </param>
		/// <param name="PlaybackSpeed">
		/// The speed at which the animation should play
		/// </param>
		/// <param name="bRestoreState">
		/// Restores widgets to their pre-animated state when the animation stops
		/// </param>
		public virtual UUMGSequencePlayer PlayAnimationTimeRange(UWidgetAnimation InAnimation, float StartAtTime = 0.000000f, float EndAtTime = 0.000000f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1.000000f, bool bRestoreState = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartAtTime;

				*(float*)(__InBuffer + 12) = EndAtTime;

				*(int*)(__InBuffer + 16) = NumLoopsToPlay;

				*(byte*)(__InBuffer + 20) = (byte)PlayMode;

				*(float*)(__InBuffer + 21) = PlaybackSpeed;

				*(bool*)(__InBuffer + 25) = bRestoreState;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlayAnimationTimeRange, __InBuffer, __ReturnBuffer);

				return *(UUMGSequencePlayer*)__ReturnBuffer;
			}
		}

		/// <param name="InAnimation">
		/// The animation to play
		/// </param>
		/// <param name="PlayMode">
		/// Specifies the playback mode
		/// </param>
		/// <param name="PlaybackSpeed">
		/// The speed at which the animation should play
		/// </param>
		/// <param name="bRestoreState">
		/// Restores widgets to their pre-animated state when the animation stops
		/// </param>
		public virtual UUMGSequencePlayer PlayAnimationReverse(UWidgetAnimation InAnimation, float PlaybackSpeed = 1.000000f, bool bRestoreState = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PlaybackSpeed;

				*(bool*)(__InBuffer + 12) = bRestoreState;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlayAnimationReverse, __InBuffer, __ReturnBuffer);

				return *(UUMGSequencePlayer*)__ReturnBuffer;
			}
		}

		/// <param name="InAnimation">
		/// The animation to play
		/// </param>
		/// <param name="PlayMode">
		/// Specifies the playback mode
		/// </param>
		/// <param name="PlaybackSpeed">
		/// The speed at which the animation should play
		/// </param>
		/// <param name="bRestoreState">
		/// Restores widgets to their pre-animated state when the animation stops
		/// </param>
		public virtual UUMGSequencePlayer PlayAnimationForward(UWidgetAnimation InAnimation, float PlaybackSpeed = 1.000000f, bool bRestoreState = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PlaybackSpeed;

				*(bool*)(__InBuffer + 12) = bRestoreState;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlayAnimationForward, __InBuffer, __ReturnBuffer);

				return *(UUMGSequencePlayer*)__ReturnBuffer;
			}
		}

		/// <param name="InAnimation">
		/// The animation to play
		/// </param>
		/// <param name="StartAtTime">
		/// The time in the animation from which to start playing, relative to the start position. For looped animations, this will only affect the first playback of the animation.
		/// </param>
		/// <param name="NumLoopsToPlay">
		/// The number of times to loop this animation (0 to loop indefinitely)
		/// </param>
		/// <param name="PlaybackSpeed">
		/// The speed at which the animation should play
		/// </param>
		/// <param name="PlayMode">
		/// Specifies the playback mode
		/// </param>
		/// <param name="bRestoreState">
		/// Restores widgets to their pre-animated state when the animation stops
		/// </param>
		public virtual UUMGSequencePlayer PlayAnimation(UWidgetAnimation InAnimation, float StartAtTime = 0.000000f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1.000000f, bool bRestoreState = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartAtTime;

				*(int*)(__InBuffer + 12) = NumLoopsToPlay;

				*(byte*)(__InBuffer + 16) = (byte)PlayMode;

				*(float*)(__InBuffer + 17) = PlaybackSpeed;

				*(bool*)(__InBuffer + 21) = bRestoreState;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __PlayAnimation, __InBuffer, __ReturnBuffer);

				return *(UUMGSequencePlayer*)__ReturnBuffer;
			}
		}

		/// <param name="The">
		/// name of the animation to pause
		/// </param>
		/// <returns>
		/// the time point the animation was at when it was paused, relative to its start position.  Use this as the StartAtTime when you trigger PlayAnimation.
		/// </returns>
		public virtual float PauseAnimation(UWidgetAnimation InAnimation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PauseAnimation, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="InTouchEvent">
		/// The touch event generated
		/// </param>
		public virtual FEventReply OnTouchStarted(FGeometry MyGeometry, FPointerEvent InTouchEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTouchEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnTouchStarted, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="InTouchEvent">
		/// The touch event generated
		/// </param>
		public virtual FEventReply OnTouchMoved(FGeometry MyGeometry, FPointerEvent InTouchEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTouchEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnTouchMoved, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="GestureEvent">
		/// gesture event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnTouchGesture(FGeometry MyGeometry, FPointerEvent GestureEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GestureEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnTouchGesture, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="InTouchEvent">
		/// The touch event generated
		/// </param>
		public virtual FEventReply OnTouchForceChanged(FGeometry MyGeometry, FPointerEvent InTouchEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTouchEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnTouchForceChanged, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="InTouchEvent">
		/// The touch event generated
		/// </param>
		public virtual FEventReply OnTouchEnded(FGeometry MyGeometry, FPointerEvent InTouchEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTouchEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnTouchEnded, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="InFocusEvent">
		/// FocusEvent
		/// </param>
		public virtual void OnRemovedFromFocusPath(FFocusEvent InFocusEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFocusEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnRemovedFromFocusPath, __InBuffer);
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="MouseEvent">
		/// Information about the input event
		/// </param>
		/// <returns>
		/// Whether the event was handled along with possible requests for the system to take action.
		/// </returns>
		public virtual FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnPreviewMouseButtonDown, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="InKeyEvent">
		/// Key event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnPreviewKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InKeyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnPreviewKeyDown, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public virtual void OnPaint(ref FPaintContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __OnPaint, __InBuffer, __OutBuffer);

				Context = *(FPaintContext*)(__OutBuffer);

			}
		}

		/// <param name="MouseEvent">
		/// Mouse event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnMouseWheel(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnMouseWheel, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="MouseEvent">
		/// Information about the input event
		/// </param>
		/// <returns>
		/// Whether the event was handled along with possible requests for the system to take action.
		/// </returns>
		public virtual FEventReply OnMouseMove(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnMouseMove, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MouseEvent">
		/// Information about the input event
		/// </param>
		public virtual void OnMouseLeave(FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnMouseLeave, __InBuffer);
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="MouseEvent">
		/// Information about the input event
		/// </param>
		public virtual void OnMouseEnter(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnMouseEnter, __InBuffer);
			}
		}

		public virtual void OnMouseCaptureLost()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnMouseCaptureLost);
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="MouseEvent">
		/// Information about the input event
		/// </param>
		/// <returns>
		/// Whether the event was handled along with possible requests for the system to take action.
		/// </returns>
		public virtual FEventReply OnMouseButtonUp(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnMouseButtonUp, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="MouseEvent">
		/// Information about the input event
		/// </param>
		/// <returns>
		/// Whether the event was handled along with possible requests for the system to take action.
		/// </returns>
		public virtual FEventReply OnMouseButtonDown(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnMouseButtonDown, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="InMyGeometry">
		/// Widget geometry
		/// </param>
		/// <param name="InMouseEvent">
		/// Mouse button event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry, FPointerEvent InMouseEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InMyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMouseEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnMouseButtonDoubleClick, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="MotionEvent">
		/// The motion event generated
		/// </param>
		public virtual FEventReply OnMotionDetected(FGeometry MyGeometry, FMotionEvent InMotionEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InMotionEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnMotionDetected, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="InKeyEvent">
		/// Key event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnKeyUp(FGeometry MyGeometry, FKeyEvent InKeyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InKeyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnKeyUp, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="InKeyEvent">
		/// Key event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InKeyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnKeyDown, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="InCharacterEvent">
		/// Character event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnKeyChar(FGeometry MyGeometry, FCharacterEvent InCharacterEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InCharacterEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnKeyChar, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		public virtual void OnInitialized()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnInitialized);
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="InFocusEvent">
		/// FocusEvent
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnFocusReceived(FGeometry MyGeometry, FFocusEvent InFocusEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFocusEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnFocusReceived, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="InFocusEvent">
		/// FocusEvent
		/// </param>
		public virtual void OnFocusLost(FFocusEvent InFocusEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFocusEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnFocusLost, __InBuffer);
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="PointerEvent">
		/// The mouse event from when the drag occurred over the widget.
		/// </param>
		/// <param name="Operation">
		/// The drag operation over the widget.
		/// </param>
		/// <returns>
		/// 'true' to indicate you handled the drop operation.
		/// </returns>
		public virtual bool OnDrop(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __OnDrop, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="PointerEvent">
		/// The mouse event from when the drag occurred over the widget.
		/// </param>
		/// <param name="Operation">
		/// The drag operation over the widget.
		/// </param>
		/// <returns>
		/// 'true' to indicate that you handled the drag over operation.  Returning 'false' will cause the operation to continue to bubble up.
		/// </returns>
		public virtual bool OnDragOver(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __OnDragOver, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="PointerEvent">
		/// The mouse event from when the drag left the widget.
		/// </param>
		/// <param name="Operation">
		/// The drag operation that entered the widget.
		/// </param>
		public virtual void OnDragLeave(FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnDragLeave, __InBuffer);
			}
		}

		/// <param name="MyGeometry">
		/// The geometry of the widget receiving the event.
		/// </param>
		/// <param name="PointerEvent">
		/// The mouse event from when the drag entered the widget.
		/// </param>
		/// <param name="Operation">
		/// The drag operation that entered the widget.
		/// </param>
		public virtual void OnDragEnter(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnDragEnter, __InBuffer);
			}
		}

		/// <param name="InMyGeometry">
		/// Widget geometry
		/// </param>
		/// <param name="PointerEvent">
		/// MouseMove that triggered the drag
		/// </param>
		/// <param name="Operation">
		/// The drag operation that was detected.
		/// </param>
		public virtual void OnDragDetected(FGeometry MyGeometry, FPointerEvent PointerEvent, ref UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __OnDragDetected, __InBuffer, __OutBuffer);

				Operation = *(UDragDropOperation*)(__OutBuffer);

			}
		}

		/// <param name="PointerEvent">
		/// Last mouse event from when the drag was canceled.
		/// </param>
		/// <param name="Operation">
		/// The drag operation that was canceled.
		/// </param>
		public virtual void OnDragCancelled(FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PointerEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Operation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnDragCancelled, __InBuffer);
			}
		}

		/// <param name="Animation">
		/// the animation that started
		/// </param>
		public virtual void OnAnimationStarted(UWidgetAnimation Animation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnAnimationStarted, __InBuffer);
			}
		}

		/// <param name="Animation">
		/// The animation that has finished playing
		/// </param>
		public virtual void OnAnimationFinished(UWidgetAnimation Animation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnAnimationFinished, __InBuffer);
			}
		}

		/// <param name="MyGeometry">
		/// The Geometry of the widget receiving the event
		/// </param>
		/// <param name="InAnalogInputEvent">
		/// Analog Event
		/// </param>
		/// <returns>
		/// Returns whether the event was handled, along with other possible actions
		/// </returns>
		public virtual FEventReply OnAnalogValueChanged(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MyGeometry?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InAnalogInputEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnAnalogValueChanged, __InBuffer, __ReturnBuffer);

				return *(FEventReply*)__ReturnBuffer;
			}
		}

		/// <param name="InFocusEvent">
		/// FocusEvent
		/// </param>
		public virtual void OnAddedToFocusPath(FFocusEvent InFocusEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFocusEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnAddedToFocusPath, __InBuffer);
			}
		}

		public virtual void ListenForInputAction(FName ActionName, EInputEvent EventType, bool bConsume, FOnInputAction Callback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = ActionName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EventType;

				*(bool*)(__InBuffer + 9) = bConsume;

				*(nint*)(__InBuffer + 10) = Callback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ListenForInputAction, __InBuffer);
			}
		}

		public virtual bool IsPlayingAnimation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlayingAnimation, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsListeningForInputAction(FName ActionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsListeningForInputAction, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsInteractable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall1Implementation(GarbageCollectionHandle, __IsInteractable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if any animation is currently playing
		/// </returns>
		public virtual bool IsAnyAnimationPlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsAnyAnimationPlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InAnimation">
		/// The playing animation that we want to know about
		/// </param>
		public virtual bool IsAnimationPlayingForward(UWidgetAnimation InAnimation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsAnimationPlayingForward, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InAnimation">
		/// The animation to check the playback status of
		/// </param>
		/// <returns>
		/// True if the animation is currently playing
		/// </returns>
		public virtual bool IsAnimationPlaying(UWidgetAnimation InAnimation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsAnimationPlaying, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Gets the owning player pawn that's owned by the player controller assigned to this widget.
		/// </returns>
		public virtual APawn GetOwningPlayerPawn()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningPlayerPawn, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Gets the owning player camera manager that's owned by the player controller assigned to this widget.
		/// </returns>
		public virtual APlayerCameraManager GetOwningPlayerCameraManager()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningPlayerCameraManager, __ReturnBuffer);

				return *(APlayerCameraManager*)__ReturnBuffer;
			}
		}

		public virtual bool GetIsVisible()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetIsVisible, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<UUserWidgetExtension> GetExtensions(TSubclassOf<UUserWidgetExtension> ExtensionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ExtensionType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetExtensions, __InBuffer, __ReturnBuffer);

				return *(TArray<UUserWidgetExtension>*)__ReturnBuffer;
			}
		}

		public virtual UUserWidgetExtension GetExtension(TSubclassOf<UUserWidgetExtension> ExtensionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ExtensionType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetExtension, __InBuffer, __ReturnBuffer);

				return *(UUserWidgetExtension*)__ReturnBuffer;
			}
		}

		/// <param name="The">
		/// name of the animation to get the current time for
		/// </param>
		/// <returns>
		/// the current time of the animation.
		/// </returns>
		public virtual float GetAnimationCurrentTime(UWidgetAnimation InAnimation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetAnimationCurrentTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FAnchors GetAnchorsInViewport()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnchorsInViewport, __ReturnBuffer);

				return *(FAnchors*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetAlignmentInViewport()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAlignmentInViewport, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual void FlushAnimations()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FlushAnimations);
			}
		}

		public virtual void Destruct()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __Destruct);
			}
		}

		public virtual void Construct()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __Construct);
			}
		}

		public virtual void CancelLatentActions()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CancelLatentActions);
			}
		}

		/// <param name="Animation">
		/// the animation to listen for starting or finishing.
		/// </param>
		/// <param name="Delegate">
		/// the delegate to call when the animation's state changes
		/// </param>
		public virtual void BindToAnimationStarted(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BindToAnimationStarted, __InBuffer);
			}
		}

		/// <param name="Animation">
		/// the animation to listen for starting or finishing.
		/// </param>
		/// <param name="Delegate">
		/// the delegate to call when the animation's state changes
		/// </param>
		public virtual void BindToAnimationFinished(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BindToAnimationFinished, __InBuffer);
			}
		}

		/// <param name="Animation">
		/// the animation to listen for starting or finishing.
		/// </param>
		/// <param name="Delegate">
		/// the delegate to call when the animation's state changes
		/// </param>
		/// <param name="AnimationEvent">
		/// the event to watch for.
		/// </param>
		/// <param name="UserTag">
		/// Scopes the delegate to only be called when the animation completes with a specific tag set on it when it was played.
		/// </param>
		public virtual void BindToAnimationEvent(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate, EWidgetAnimationEvent AnimationEvent, FName UserTag = null)
		{
			unsafe
			{
				UserTag ??= new FName("None");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Animation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)AnimationEvent;

				*(nint*)(__InBuffer + 17) = UserTag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BindToAnimationEvent, __InBuffer);
			}
		}

		/// <param name="ZOrder">
		/// The higher the number, the more on top this widget will be.
		/// </param>
		public virtual void AddToViewport(int ZOrder = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ZOrder;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddToViewport, __InBuffer);
			}
		}

		/// <param name="ZOrder">
		/// The higher the number, the more on top this widget will be.
		/// </param>
		public virtual bool AddToPlayerScreen(int ZOrder = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ZOrder;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddToPlayerScreen, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UUserWidgetExtension AddExtension(TSubclassOf<UUserWidgetExtension> InExtensionType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InExtensionType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddExtension, __InBuffer, __ReturnBuffer);

				return *(UUserWidgetExtension*)__ReturnBuffer;
			}
		}

		private static uint __ColorAndOpacity = 0;

		private static uint __ColorAndOpacityDelegate = 0;

		private static uint __ForegroundColor = 0;

		private static uint __ForegroundColorDelegate = 0;

		private static uint __OnVisibilityChanged = 0;

		private static uint __Padding = 0;

		private static uint __Priority = 0;

		private static uint __bIsFocusable = 0;

		private static uint __bStopAction = 0;

		private static uint __ActiveSequencePlayers = 0;

		private static uint __AnimationTickManager = 0;

		private static uint __StoppedSequencePlayers = 0;

		private static uint __NamedSlotBindings = 0;

		private static uint __Extensions = 0;

		private static uint __WidgetTree = 0;

		private static uint __DesignTimeSize = 0;

		private static uint __DesignSizeMode = 0;

		private static uint __PaletteCategory = 0;

		private static uint __PreviewBackground = 0;

		private static uint __bHasScriptImplementedTick = 0;

		private static uint __bHasScriptImplementedPaint = 0;

		private static uint __TickFrequency = 0;

		private static uint __DesiredFocusWidget = 0;

		private static uint __InputComponent = 0;

		private static uint __AnimationCallbacks = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UnregisterInputComponent = 0;

		private static uint __UnbindFromAnimationStarted = 0;

		private static uint __UnbindFromAnimationFinished = 0;

		private static uint __UnbindAllFromAnimationStarted = 0;

		private static uint __UnbindAllFromAnimationFinished = 0;

		private static uint __Tick = 0;

		private static uint __StopListeningForInputAction = 0;

		private static uint __StopListeningForAllInputActions = 0;

		private static uint __StopAnimationsAndLatentActions = 0;

		private static uint __StopAnimation = 0;

		private static uint __StopAllAnimations = 0;

		private static uint __SetPositionInViewport = 0;

		private static uint __SetPlaybackSpeed = 0;

		private static uint __SetPadding = 0;

		private static uint __SetOwningPlayer = 0;

		private static uint __SetNumLoopsToPlay = 0;

		private static uint __SetInputActionPriority = 0;

		private static uint __SetInputActionBlocking = 0;

		private static uint __SetForegroundColor = 0;

		private static uint __SetDesiredSizeInViewport = 0;

		private static uint __SetColorAndOpacity = 0;

		private static uint __SetAnimationCurrentTime = 0;

		private static uint __SetAnchorsInViewport = 0;

		private static uint __SetAlignmentInViewport = 0;

		private static uint __ReverseAnimation = 0;

		private static uint __RemoveFromViewport = 0;

		private static uint __RemoveExtensions = 0;

		private static uint __RemoveExtension = 0;

		private static uint __RegisterInputComponent = 0;

		private static uint __PreConstruct = 0;

		private static uint __PlaySound = 0;

		private static uint __PlayAnimationTimeRange = 0;

		private static uint __PlayAnimationReverse = 0;

		private static uint __PlayAnimationForward = 0;

		private static uint __PlayAnimation = 0;

		private static uint __PauseAnimation = 0;

		private static uint __OnTouchStarted = 0;

		private static uint __OnTouchMoved = 0;

		private static uint __OnTouchGesture = 0;

		private static uint __OnTouchForceChanged = 0;

		private static uint __OnTouchEnded = 0;

		private static uint __OnRemovedFromFocusPath = 0;

		private static uint __OnPreviewMouseButtonDown = 0;

		private static uint __OnPreviewKeyDown = 0;

		private static uint __OnPaint = 0;

		private static uint __OnMouseWheel = 0;

		private static uint __OnMouseMove = 0;

		private static uint __OnMouseLeave = 0;

		private static uint __OnMouseEnter = 0;

		private static uint __OnMouseCaptureLost = 0;

		private static uint __OnMouseButtonUp = 0;

		private static uint __OnMouseButtonDown = 0;

		private static uint __OnMouseButtonDoubleClick = 0;

		private static uint __OnMotionDetected = 0;

		private static uint __OnKeyUp = 0;

		private static uint __OnKeyDown = 0;

		private static uint __OnKeyChar = 0;

		private static uint __OnInitialized = 0;

		private static uint __OnFocusReceived = 0;

		private static uint __OnFocusLost = 0;

		private static uint __OnDrop = 0;

		private static uint __OnDragOver = 0;

		private static uint __OnDragLeave = 0;

		private static uint __OnDragEnter = 0;

		private static uint __OnDragDetected = 0;

		private static uint __OnDragCancelled = 0;

		private static uint __OnAnimationStarted = 0;

		private static uint __OnAnimationFinished = 0;

		private static uint __OnAnalogValueChanged = 0;

		private static uint __OnAddedToFocusPath = 0;

		private static uint __ListenForInputAction = 0;

		private static uint __IsPlayingAnimation = 0;

		private static uint __IsListeningForInputAction = 0;

		private static uint __IsInteractable = 0;

		private static uint __IsAnyAnimationPlaying = 0;

		private static uint __IsAnimationPlayingForward = 0;

		private static uint __IsAnimationPlaying = 0;

		private static uint __GetOwningPlayerPawn = 0;

		private static uint __GetOwningPlayerCameraManager = 0;

		private static uint __GetIsVisible = 0;

		private static uint __GetExtensions = 0;

		private static uint __GetExtension = 0;

		private static uint __GetAnimationCurrentTime = 0;

		private static uint __GetAnchorsInViewport = 0;

		private static uint __GetAlignmentInViewport = 0;

		private static uint __FlushAnimations = 0;

		private static uint __Destruct = 0;

		private static uint __Construct = 0;

		private static uint __CancelLatentActions = 0;

		private static uint __BindToAnimationStarted = 0;

		private static uint __BindToAnimationFinished = 0;

		private static uint __BindToAnimationEvent = 0;

		private static uint __AddToViewport = 0;

		private static uint __AddToPlayerScreen = 0;

		private static uint __AddExtension = 0;
	}
}