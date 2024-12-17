using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HUD")]
	public partial class AHUD : AActor, IStaticClass
	{
		public APlayerController PlayerOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerOwner, __ReturnBuffer);

					return *(APlayerController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerOwner, __InBuffer);
				}
			}
		}

		public bool bLostFocusPaused
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLostFocusPaused, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLostFocusPaused, __InBuffer);
				}
			}
		}

		public bool bShowHUD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowHUD, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowHUD, __InBuffer);
				}
			}
		}

		public bool bShowDebugInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowDebugInfo, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowDebugInfo, __InBuffer);
				}
			}
		}

		public int CurrentTargetIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTargetIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentTargetIndex, __InBuffer);
				}
			}
		}

		public bool bShowHitBoxDebugInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowHitBoxDebugInfo, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowHitBoxDebugInfo, __InBuffer);
				}
			}
		}

		public bool bShowOverlays
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOverlays, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOverlays, __InBuffer);
				}
			}
		}

		public bool bEnableDebugTextShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDebugTextShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableDebugTextShadow, __InBuffer);
				}
			}
		}

		public TArray<AActor> PostRenderedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostRenderedActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostRenderedActors, __InBuffer);
				}
			}
		}

		public TArray<FName> DebugDisplay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugDisplay, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugDisplay, __InBuffer);
				}
			}
		}

		public TArray<FName> ToggledDebugCategories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToggledDebugCategories, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToggledDebugCategories, __InBuffer);
				}
			}
		}

		public UCanvas Canvas
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Canvas, __ReturnBuffer);

					return *(UCanvas*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Canvas, __InBuffer);
				}
			}
		}

		public UCanvas DebugCanvas
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugCanvas, __ReturnBuffer);

					return *(UCanvas*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugCanvas, __InBuffer);
				}
			}
		}

		public TArray<FDebugTextInfo> DebugTextList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugTextList, __ReturnBuffer);

					return *(TArray<FDebugTextInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugTextList, __InBuffer);
				}
			}
		}

		public TSubclassOf<AActor> ShowDebugTargetDesiredClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowDebugTargetDesiredClass, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowDebugTargetDesiredClass, __InBuffer);
				}
			}
		}

		public AActor ShowDebugTargetActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowDebugTargetActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowDebugTargetActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HUD");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ShowHUD()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShowHUD);
			}
		}

		public virtual void ShowDebugToggleSubCategory(FName Category)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Category?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowDebugToggleSubCategory, __InBuffer);
			}
		}

		public virtual void ShowDebugForReticleTargetToggle(TSubclassOf<AActor> DesiredClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DesiredClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowDebugForReticleTargetToggle, __InBuffer);
			}
		}

		public virtual void ShowDebug(FName DebugType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DebugType?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowDebug, __InBuffer);
			}
		}

		/// <param name="SrcActor">
		/// Actor whose string you wish to remove
		/// </param>
		/// <param name="bLeaveDurationText">
		/// when true text that has a finite duration will be removed, otherwise all will be removed for given actor
		/// </param>
		public virtual void RemoveDebugText(AActor SrcActor, bool bLeaveDurationText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SrcActor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLeaveDurationText;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __RemoveDebugText, __InBuffer);
			}
		}

		public virtual void RemoveAllDebugStrings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __RemoveAllDebugStrings);
			}
		}

		public virtual void ReceiveHitBoxRelease(FName BoxName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoxName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveHitBoxRelease, __InBuffer);
			}
		}

		public virtual void ReceiveHitBoxEndCursorOver(FName BoxName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoxName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveHitBoxEndCursorOver, __InBuffer);
			}
		}

		public virtual void ReceiveHitBoxClick(FName BoxName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoxName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveHitBoxClick, __InBuffer);
			}
		}

		public virtual void ReceiveHitBoxBeginCursorOver(FName BoxName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoxName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveHitBoxBeginCursorOver, __InBuffer);
			}
		}

		/// <see>
		/// bSuppressNativeHUD to control HUD drawing in base class. 
		/// Note:  the canvas resource used for drawing is only valid during this event, it will not be valid if drawing functions are called later (e.g. after a Delay node).
		/// </see>
		public virtual void ReceiveDrawHUD(int SizeX, int SizeY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = SizeX;

				*(int*)(__InBuffer + 4) = SizeY;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveDrawHUD, __InBuffer);
			}
		}

		/// <param name="Location">
		/// The world-space position to transform
		/// </param>
		/// <param name="bClampToZeroPlane">
		/// If true, 2D screen coordinates behind the viewing plane (-Z) will have Z set to 0 (leaving X and Y alone)
		/// </param>
		/// <returns>
		/// The transformed vector
		/// </returns>
		public virtual FVector Project(FVector Location, bool bClampToZeroPlane = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bClampToZeroPlane;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Project, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual void PreviousDebugTarget()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PreviousDebugTarget);
			}
		}

		public virtual void NextDebugTarget()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __NextDebugTarget);
			}
		}

		/// <param name="Text">
		/// String to draw
		/// </param>
		/// <param name="OutWidth">
		/// Returns the width in pixels of the string.
		/// </param>
		/// <param name="OutHeight">
		/// Returns the height in pixels of the string.
		/// </param>
		/// <param name="Font">
		/// Font to draw text.  If NULL, default font is chosen.
		/// </param>
		/// <param name="Scale">
		/// Scale multiplier to control size of the text.
		/// </param>
		public virtual void GetTextSize(FString Text, ref float OutWidth, ref float OutHeight, UFont Font, float Scale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = OutWidth;

				*(float*)(__InBuffer + 12) = OutHeight;

				*(nint*)(__InBuffer + 16) = Font?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Scale;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTextSize, __InBuffer, __OutBuffer);

				OutWidth = *(float*)(__OutBuffer);

				OutHeight = *(float*)(__OutBuffer + 4);

			}
		}

		public virtual APlayerController GetOwningPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public virtual APawn GetOwningPawn()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningPawn, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		/// <param name="FirstPoint">
		/// The first point, or anchor of the marquee box. Where the dragging of the marquee started in screen space.
		/// </param>
		/// <param name="SecondPoint">
		/// The second point, where the mouse cursor currently is / the other point of the box selection, in screen space.
		/// </param>
		/// <param name="bIncludeNonCollidingComponents">
		/// Whether to include even non-colliding components of the actor when determining its bounds
		/// </param>
		/// <param name="bActorMustBeFullyEnclosed">
		/// The Selection rule: whether the selection box can partially intersect Actor, or must fully enclose the Actor.
		/// </param>
		/// <returns>
		/// OutActors					The actors that are within the selection box according to selection rule
		/// </returns>
		public virtual void GetActorsInSelectionRectangle(TSubclassOf<AActor> ClassFilter, FVector2D FirstPoint, FVector2D SecondPoint, ref TArray<AActor> OutActors, bool bIncludeNonCollidingComponents, bool bActorMustBeFullyEnclosed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = ClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FirstPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SecondPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bIncludeNonCollidingComponents;

				*(bool*)(__InBuffer + 33) = bActorMustBeFullyEnclosed;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetActorsInSelectionRectangle, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="Texture">
		/// Texture to draw.
		/// </param>
		/// <param name="ScreenX">
		/// Screen-space X coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenY">
		/// Screen-space Y coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="Scale">
		/// Scale multiplier to control size of the text.
		/// </param>
		/// <param name="bScalePosition">
		/// Whether the "Scale" parameter should also scale the position of this draw call.
		/// </param>
		public virtual void DrawTextureSimple(UTexture Texture, float ScreenX, float ScreenY, float Scale = 1.000000f, bool bScalePosition = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ScreenX;

				*(float*)(__InBuffer + 12) = ScreenY;

				*(float*)(__InBuffer + 16) = Scale;

				*(bool*)(__InBuffer + 20) = bScalePosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawTextureSimple, __InBuffer);
			}
		}

		/// <param name="Texture">
		/// Texture to draw.
		/// </param>
		/// <param name="ScreenX">
		/// Screen-space X coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenY">
		/// Screen-space Y coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenW">
		/// Screen-space width of the quad (in pixels).
		/// </param>
		/// <param name="ScreenH">
		/// Screen-space height of the quad (in pixels).
		/// </param>
		/// <param name="TextureU">
		/// Texture-space U coordinate of upper left corner of the quad
		/// </param>
		/// <param name="TextureV">
		/// Texture-space V coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="TextureUWidth">
		/// Texture-space width of the quad (in normalized UV distance).
		/// </param>
		/// <param name="TextureVHeight">
		/// Texture-space height of the quad (in normalized UV distance).
		/// </param>
		/// <param name="TintColor">
		/// Vertex color for the quad.
		/// </param>
		/// <param name="BlendMode">
		/// Controls how to blend this quad with the scene. Translucent by default.
		/// </param>
		/// <param name="Scale">
		/// Amount to scale the entire texture (horizontally and vertically)
		/// </param>
		/// <param name="bScalePosition">
		/// Whether the "Scale" parameter should also scale the position of this draw call.
		/// </param>
		/// <param name="Rotation">
		/// Amount to rotate this quad
		/// </param>
		/// <param name="RotPivot">
		/// Location (as proportion of quad, 0-1) to rotate about
		/// </param>
		public virtual void DrawTexture(UTexture Texture, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float TextureU, float TextureV, float TextureUWidth, float TextureVHeight, FLinearColor TintColor = null, EBlendMode BlendMode = EBlendMode.BLEND_Translucent, float Scale = 1.000000f, bool bScalePosition = false, float Rotation = 0.000000f, FVector2D RotPivot = null)
		{
			unsafe
			{
				TintColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				RotPivot ??= new FVector2D();

				var __InBuffer = stackalloc byte[66];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ScreenX;

				*(float*)(__InBuffer + 12) = ScreenY;

				*(float*)(__InBuffer + 16) = ScreenW;

				*(float*)(__InBuffer + 20) = ScreenH;

				*(float*)(__InBuffer + 24) = TextureU;

				*(float*)(__InBuffer + 28) = TextureV;

				*(float*)(__InBuffer + 32) = TextureUWidth;

				*(float*)(__InBuffer + 36) = TextureVHeight;

				*(nint*)(__InBuffer + 40) = TintColor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 48) = (byte)BlendMode;

				*(float*)(__InBuffer + 49) = Scale;

				*(bool*)(__InBuffer + 53) = bScalePosition;

				*(float*)(__InBuffer + 54) = Rotation;

				*(nint*)(__InBuffer + 58) = RotPivot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawTexture, __InBuffer);
			}
		}

		/// <param name="Text">
		/// String to draw
		/// </param>
		/// <param name="TextColor">
		/// Color to draw string
		/// </param>
		/// <param name="ScreenX">
		/// Screen-space X coordinate of upper left corner of the string.
		/// </param>
		/// <param name="ScreenY">
		/// Screen-space Y coordinate of upper left corner of the string.
		/// </param>
		/// <param name="Font">
		/// Font to draw text.  If NULL, default font is chosen.
		/// </param>
		/// <param name="Scale">
		/// Scale multiplier to control size of the text.
		/// </param>
		/// <param name="bScalePosition">
		/// Whether the "Scale" parameter should also scale the position of this draw call.
		/// </param>
		public virtual void DrawText(FString Text, FLinearColor TextColor, float ScreenX, float ScreenY, UFont Font = null, float Scale = 1.000000f, bool bScalePosition = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = ScreenX;

				*(float*)(__InBuffer + 20) = ScreenY;

				*(nint*)(__InBuffer + 24) = Font?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Scale;

				*(bool*)(__InBuffer + 36) = bScalePosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawText, __InBuffer);
			}
		}

		/// <param name="RectColor">
		/// Color of the rect. Can be translucent.
		/// </param>
		/// <param name="ScreenX">
		/// Screen-space X coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenY">
		/// Screen-space Y coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenW">
		/// Screen-space width of the quad (in pixels).
		/// </param>
		/// <param name="ScreenH">
		/// Screen-space height of the quad (in pixels).
		/// </param>
		public virtual void DrawRect(FLinearColor RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RectColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ScreenX;

				*(float*)(__InBuffer + 12) = ScreenY;

				*(float*)(__InBuffer + 16) = ScreenW;

				*(float*)(__InBuffer + 20) = ScreenH;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawRect, __InBuffer);
			}
		}

		public virtual void DrawMaterialTriangle(UMaterialInterface Material, FVector2D V0_Pos, FVector2D V1_Pos, FVector2D V2_Pos, FVector2D V0_UV, FVector2D V1_UV, FVector2D V2_UV, FLinearColor V0_Color = null, FLinearColor V1_Color = null, FLinearColor V2_Color = null)
		{
			unsafe
			{
				V0_Color ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				V1_Color ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				V2_Color ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[80];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = V0_Pos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = V1_Pos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = V2_Pos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = V0_UV?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = V1_UV?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = V2_UV?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = V0_Color?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 64) = V1_Color?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 72) = V2_Color?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawMaterialTriangle, __InBuffer);
			}
		}

		/// <param name="Material">
		/// Material to use
		/// </param>
		/// <param name="ScreenX">
		/// Screen-space X coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenY">
		/// Screen-space Y coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenW">
		/// Screen-space width of the quad (in pixels).
		/// </param>
		/// <param name="ScreenH">
		/// Screen-space height of the quad (in pixels).
		/// </param>
		/// <param name="Scale">
		/// Amount to scale the entire texture (horizontally and vertically)
		/// </param>
		/// <param name="bScalePosition">
		/// Whether the "Scale" parameter should also scale the position of this draw call.
		/// </param>
		public virtual void DrawMaterialSimple(UMaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float Scale = 1.000000f, bool bScalePosition = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ScreenX;

				*(float*)(__InBuffer + 12) = ScreenY;

				*(float*)(__InBuffer + 16) = ScreenW;

				*(float*)(__InBuffer + 20) = ScreenH;

				*(float*)(__InBuffer + 24) = Scale;

				*(bool*)(__InBuffer + 28) = bScalePosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawMaterialSimple, __InBuffer);
			}
		}

		/// <param name="Material">
		/// Material to use
		/// </param>
		/// <param name="ScreenX">
		/// Screen-space X coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenY">
		/// Screen-space Y coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="ScreenW">
		/// Screen-space width of the quad (in pixels).
		/// </param>
		/// <param name="ScreenH">
		/// Screen-space height of the quad (in pixels).
		/// </param>
		/// <param name="MaterialU">
		/// Texture-space U coordinate of upper left corner of the quad
		/// </param>
		/// <param name="MaterialV">
		/// Texture-space V coordinate of upper left corner of the quad.
		/// </param>
		/// <param name="MaterialUWidth">
		/// Texture-space width of the quad (in normalized UV distance).
		/// </param>
		/// <param name="MaterialVHeight">
		/// Texture-space height of the quad (in normalized UV distance).
		/// </param>
		/// <param name="Scale">
		/// Amount to scale the entire texture (horizontally and vertically)
		/// </param>
		/// <param name="bScalePosition">
		/// Whether the "Scale" parameter should also scale the position of this draw call.
		/// </param>
		/// <param name="Rotation">
		/// Amount to rotate this quad
		/// </param>
		/// <param name="RotPivot">
		/// Location (as proportion of quad, 0-1) to rotate about
		/// </param>
		public virtual void DrawMaterial(UMaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float MaterialU, float MaterialV, float MaterialUWidth, float MaterialVHeight, float Scale = 1.000000f, bool bScalePosition = false, float Rotation = 0.000000f, FVector2D RotPivot = null)
		{
			unsafe
			{
				RotPivot ??= new FVector2D();

				var __InBuffer = stackalloc byte[57];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ScreenX;

				*(float*)(__InBuffer + 12) = ScreenY;

				*(float*)(__InBuffer + 16) = ScreenW;

				*(float*)(__InBuffer + 20) = ScreenH;

				*(float*)(__InBuffer + 24) = MaterialU;

				*(float*)(__InBuffer + 28) = MaterialV;

				*(float*)(__InBuffer + 32) = MaterialUWidth;

				*(float*)(__InBuffer + 36) = MaterialVHeight;

				*(float*)(__InBuffer + 40) = Scale;

				*(bool*)(__InBuffer + 44) = bScalePosition;

				*(float*)(__InBuffer + 45) = Rotation;

				*(nint*)(__InBuffer + 49) = RotPivot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawMaterial, __InBuffer);
			}
		}

		/// <param name="StartScreenX">
		/// Screen-space X coordinate of start of the line.
		/// </param>
		/// <param name="StartScreenY">
		/// Screen-space Y coordinate of start of the line.
		/// </param>
		/// <param name="EndScreenX">
		/// Screen-space X coordinate of end of the line.
		/// </param>
		/// <param name="EndScreenY">
		/// Screen-space Y coordinate of end of the line.
		/// </param>
		/// <param name="LineColor">
		/// Color to draw line
		/// </param>
		/// <param name="LineThickness">
		/// Thickness of the line to draw
		/// </param>
		public virtual void DrawLine(float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, FLinearColor LineColor, float LineThickness = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = StartScreenX;

				*(float*)(__InBuffer + 4) = StartScreenY;

				*(float*)(__InBuffer + 8) = EndScreenX;

				*(float*)(__InBuffer + 12) = EndScreenY;

				*(nint*)(__InBuffer + 16) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = LineThickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DrawLine, __InBuffer);
			}
		}

		public virtual void Deproject(float ScreenX, float ScreenY, ref FVector WorldPosition, ref FVector WorldDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(float*)(__InBuffer) = ScreenX;

				*(float*)(__InBuffer + 4) = ScreenY;

				*(nint*)(__InBuffer + 8) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __Deproject, __InBuffer, __OutBuffer);

				WorldPosition = *(FVector*)(__OutBuffer);

				WorldDirection = *(FVector*)(__OutBuffer + 8);

			}
		}

		/// <param name="Position">
		/// Coordinates of the top left of the hit box.
		/// </param>
		/// <param name="Size">
		/// Size of the hit box.
		/// </param>
		/// <param name="Name">
		/// Name of the hit box.
		/// </param>
		/// <param name="bConsumesInput">
		/// Whether click processing should continue if this hit box is clicked.
		/// </param>
		/// <param name="Priority">
		/// The priority of the box used for layering. Larger values are considered first.  Equal values are considered in the order they were added.
		/// </param>
		public virtual void AddHitBox(FVector2D Position, FVector2D Size, FName InName, bool bConsumesInput, int Priority = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Size?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bConsumesInput;

				*(int*)(__InBuffer + 25) = Priority;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddHitBox, __InBuffer);
			}
		}

		/// <param name="DebugText">
		/// Text to draw
		/// </param>
		/// <param name="SrcActor">
		/// Actor to which this relates
		/// </param>
		/// <param name="Duration">
		/// Duration to display the string
		/// </param>
		/// <param name="Offset">
		/// Initial offset to render text
		/// </param>
		/// <param name="DesiredOffset">
		/// Desired offset to render text - the text will move to this location over the given duration
		/// </param>
		/// <param name="TextColor">
		/// Color of text to render
		/// </param>
		/// <param name="bSkipOverwriteCheck">
		/// skips the check to see if there is already debug text for the given actor
		/// </param>
		/// <param name="bAbsoluteLocation">
		/// use an absolute world location
		/// </param>
		/// <param name="bKeepAttachedToActor">
		/// if this is true the text will follow the actor, otherwise it will be drawn at the location when the call was made
		/// </param>
		/// <param name="InFont">
		/// font to use
		/// </param>
		/// <param name="FontScale">
		/// scale
		/// </param>
		/// <param name="bDrawShadow">
		/// Draw shadow on this string
		/// </param>
		public virtual void AddDebugText(FString DebugText, AActor SrcActor, float Duration, FVector Offset, FVector DesiredOffset, FColor TextColor, bool bSkipOverwriteCheck, bool bAbsoluteLocation, bool bKeepAttachedToActor, UFont InFont, float FontScale, bool bDrawShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[60];

				*(nint*)(__InBuffer) = DebugText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SrcActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Duration;

				*(nint*)(__InBuffer + 20) = Offset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = DesiredOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = TextColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 44) = bSkipOverwriteCheck;

				*(bool*)(__InBuffer + 45) = bAbsoluteLocation;

				*(bool*)(__InBuffer + 46) = bKeepAttachedToActor;

				*(nint*)(__InBuffer + 47) = InFont?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 55) = FontScale;

				*(bool*)(__InBuffer + 59) = bDrawShadow;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __AddDebugText, __InBuffer);
			}
		}

		private static uint __PlayerOwner = 0;

		private static uint __bLostFocusPaused = 0;

		private static uint __bShowHUD = 0;

		private static uint __bShowDebugInfo = 0;

		private static uint __CurrentTargetIndex = 0;

		private static uint __bShowHitBoxDebugInfo = 0;

		private static uint __bShowOverlays = 0;

		private static uint __bEnableDebugTextShadow = 0;

		private static uint __PostRenderedActors = 0;

		private static uint __DebugDisplay = 0;

		private static uint __ToggledDebugCategories = 0;

		private static uint __Canvas = 0;

		private static uint __DebugCanvas = 0;

		private static uint __DebugTextList = 0;

		private static uint __ShowDebugTargetDesiredClass = 0;

		private static uint __ShowDebugTargetActor = 0;

		private static uint __ShowHUD = 0;

		private static uint __ShowDebugToggleSubCategory = 0;

		private static uint __ShowDebugForReticleTargetToggle = 0;

		private static uint __ShowDebug = 0;

		private static uint __RemoveDebugText = 0;

		private static uint __RemoveAllDebugStrings = 0;

		private static uint __ReceiveHitBoxRelease = 0;

		private static uint __ReceiveHitBoxEndCursorOver = 0;

		private static uint __ReceiveHitBoxClick = 0;

		private static uint __ReceiveHitBoxBeginCursorOver = 0;

		private static uint __ReceiveDrawHUD = 0;

		private static uint __Project = 0;

		private static uint __PreviousDebugTarget = 0;

		private static uint __NextDebugTarget = 0;

		private static uint __GetTextSize = 0;

		private static uint __GetOwningPlayerController = 0;

		private static uint __GetOwningPawn = 0;

		private static uint __GetActorsInSelectionRectangle = 0;

		private static uint __DrawTextureSimple = 0;

		private static uint __DrawTexture = 0;

		private static uint __DrawText = 0;

		private static uint __DrawRect = 0;

		private static uint __DrawMaterialTriangle = 0;

		private static uint __DrawMaterialSimple = 0;

		private static uint __DrawMaterial = 0;

		private static uint __DrawLine = 0;

		private static uint __Deproject = 0;

		private static uint __AddHitBox = 0;

		private static uint __AddDebugText = 0;
	}
}