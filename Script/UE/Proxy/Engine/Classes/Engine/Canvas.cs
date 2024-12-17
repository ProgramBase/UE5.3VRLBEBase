using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Canvas")]
	public partial class UCanvas : UObject, IStaticClass
	{
		public float OrgX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrgX, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrgX, __InBuffer);
				}
			}
		}

		public float OrgY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OrgY, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OrgY, __InBuffer);
				}
			}
		}

		public float ClipX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClipX, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClipX, __InBuffer);
				}
			}
		}

		public float ClipY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClipY, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClipY, __InBuffer);
				}
			}
		}

		public FColor DrawColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawColor, __InBuffer);
				}
			}
		}

		public bool bCenterX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCenterX, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCenterX, __InBuffer);
				}
			}
		}

		public bool bCenterY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCenterY, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCenterY, __InBuffer);
				}
			}
		}

		public bool bNoSmooth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNoSmooth, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNoSmooth, __InBuffer);
				}
			}
		}

		public int SizeX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SizeX, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SizeX, __InBuffer);
				}
			}
		}

		public int SizeY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SizeY, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SizeY, __InBuffer);
				}
			}
		}

		public FPlane ColorModulate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorModulate, __ReturnBuffer);

					return *(FPlane*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorModulate, __InBuffer);
				}
			}
		}

		public UTexture2D DefaultTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTexture, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultTexture, __InBuffer);
				}
			}
		}

		public UTexture2D GradientTexture0
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GradientTexture0, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GradientTexture0, __InBuffer);
				}
			}
		}

		public UReporterGraph ReporterGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReporterGraph, __ReturnBuffer);

					return *(UReporterGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReporterGraph, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Canvas");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="RenderFont">
		/// Font to use when determining the size of the text. If this is null, then a default engine font is used.
		/// </param>
		/// <param name="RenderText">
		/// Text to determine the size of.
		/// </param>
		/// <param name="Scale">
		/// Scale of the font to use when determining the size of the text.
		/// </param>
		/// <returns>
		/// Returns the screen space size of the text.
		/// </returns>
		public virtual FVector2D K2_TextSize(UFont RenderFont, FString RenderText, FVector2D Scale = null)
		{
			unsafe
			{
				Scale ??= new FVector2D(1.000000, 1.000000);

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = RenderFont?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RenderText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_TextSize, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="RenderFont">
		/// Font to use when determining the size of the text. If this is null, then a default engine font is used.
		/// </param>
		/// <param name="RenderText">
		/// Text to determine the size of.
		/// </param>
		/// <returns>
		/// Returns the screen space size of the text.
		/// </returns>
		public virtual FVector2D K2_StrLen(UFont RenderFont, FString RenderText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RenderFont?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RenderText?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_StrLen, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		/// <param name="WorldLocation">
		/// World space location to project onto the Canvas rendering plane.
		/// </param>
		/// <returns>
		/// Returns a vector where X, Y defines a screen space position representing the world space location.
		/// </returns>
		public virtual FVector K2_Project(FVector WorldLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_Project, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="RenderTexture">
		/// Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
		/// </param>
		/// <param name="Triangles">
		/// Triangles to render.
		/// </param>
		public virtual void K2_DrawTriangle(UTexture RenderTexture, TArray<FCanvasUVTri> Triangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RenderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawTriangle, __InBuffer);
			}
		}

		/// <param name="RenderTexture">
		/// Texture to use when rendering. If no texture is set then this will use the default white texture.
		/// </param>
		/// <param name="ScreenPosition">
		/// Screen space position to render the texture.
		/// </param>
		/// <param name="ScreenSize">
		/// Screen space size to render the texture.
		/// </param>
		/// <param name="CoordinatePosition">
		/// Normalized UV starting coordinate to use when rendering the texture.
		/// </param>
		/// <param name="CoordinateSize">
		/// Normalized UV size coordinate to use when rendering the texture.
		/// </param>
		/// <param name="RenderColor">
		/// Color to use when rendering the texture.
		/// </param>
		/// <param name="BlendMode">
		/// Blending mode to use when rendering the texture.
		/// </param>
		/// <param name="Rotation">
		/// Rotation, in degrees, to render the texture.
		/// </param>
		/// <param name="PivotPoint">
		/// Normalized pivot point to use when rotating the texture.
		/// </param>
		public virtual void K2_DrawTexture(UTexture RenderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize = null, FLinearColor RenderColor = null, EBlendMode BlendMode = EBlendMode.BLEND_Translucent, float Rotation = 0.000000f, FVector2D PivotPoint = null)
		{
			unsafe
			{
				CoordinateSize ??= new FVector2D(1.000000, 1.000000);

				RenderColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				PivotPoint ??= new FVector2D(0.500000, 0.500000);

				var __InBuffer = stackalloc byte[61];

				*(nint*)(__InBuffer) = RenderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScreenSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = CoordinatePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = CoordinateSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = RenderColor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 48) = (byte)BlendMode;

				*(float*)(__InBuffer + 49) = Rotation;

				*(nint*)(__InBuffer + 53) = PivotPoint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawTexture, __InBuffer);
			}
		}

		/// <param name="RenderFont">
		/// Font to use when rendering the text. If this is null, then a default engine font is used.
		/// </param>
		/// <param name="RenderText">
		/// Text to render on the Canvas.
		/// </param>
		/// <param name="ScreenPosition">
		/// Screen space position to render the text.
		/// </param>
		/// <param name="RenderColor">
		/// Color to render the text.
		/// </param>
		/// <param name="Kerning">
		/// Horizontal spacing adjustment to modify the spacing between each letter.
		/// </param>
		/// <param name="ShadowColor">
		/// Color to render the shadow of the text.
		/// </param>
		/// <param name="ShadowOffset">
		/// Pixel offset relative to the screen space position to render the shadow of the text.
		/// </param>
		/// <param name="bCentreX">
		/// If true, then interpret the screen space position X coordinate as the center of the rendered text.
		/// </param>
		/// <param name="bCentreY">
		/// If true, then interpret the screen space position Y coordinate as the center of the rendered text.
		/// </param>
		/// <param name="bOutlined">
		/// If true, then the text should be rendered with an outline.
		/// </param>
		/// <param name="OutlineColor">
		/// Color to render the outline for the text.
		/// </param>
		public virtual void K2_DrawText(UFont RenderFont, FString RenderText, FVector2D ScreenPosition, FVector2D Scale = null, FLinearColor RenderColor = null, float Kerning = 0.000000f, FLinearColor ShadowColor = null, FVector2D ShadowOffset = null, bool bCentreX = false, bool bCentreY = false, bool bOutlined = false, FLinearColor OutlineColor = null)
		{
			unsafe
			{
				Scale ??= new FVector2D(1.000000, 1.000000);

				RenderColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				ShadowColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				ShadowOffset ??= new FVector2D(1.000000, 1.000000);

				OutlineColor ??= new FLinearColor(0.000000f, 0.000000f, 0.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = RenderFont?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = RenderText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Scale?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = RenderColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Kerning;

				*(nint*)(__InBuffer + 44) = ShadowColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = ShadowOffset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 60) = bCentreX;

				*(bool*)(__InBuffer + 61) = bCentreY;

				*(bool*)(__InBuffer + 62) = bOutlined;

				*(nint*)(__InBuffer + 63) = OutlineColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawText, __InBuffer);
			}
		}

		/// <param name="RenderTexture">
		/// Texture to use when rendering the triangles. If no texture is set, then the default white texture is used.
		/// </param>
		/// <param name="ScreenPosition">
		/// Screen space position to render the text.
		/// </param>
		/// <param name="Radius">
		/// How large in pixels this polygon should be.
		/// </param>
		/// <param name="NumberOfSides">
		/// How many sides this polygon should have. This should be above or equal to three.
		/// </param>
		/// <param name="RenderColor">
		/// Color to tint the polygon.
		/// </param>
		public virtual void K2_DrawPolygon(UTexture RenderTexture, FVector2D ScreenPosition, FVector2D Radius = null, int NumberOfSides = 3, FLinearColor RenderColor = null)
		{
			unsafe
			{
				Radius ??= new FVector2D(1.000000, 1.000000);

				RenderColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = RenderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Radius?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = NumberOfSides;

				*(nint*)(__InBuffer + 28) = RenderColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawPolygon, __InBuffer);
			}
		}

		/// <param name="RenderMaterial">
		/// Material to use when rendering. Remember that only the emissive channel is able to be rendered as no lighting is performed when rendering to the Canvas.
		/// </param>
		/// <param name="Triangles">
		/// Triangles to render.
		/// </param>
		public virtual void K2_DrawMaterialTriangle(UMaterialInterface RenderMaterial, TArray<FCanvasUVTri> Triangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RenderMaterial?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawMaterialTriangle, __InBuffer);
			}
		}

		/// <param name="RenderMaterial">
		/// Material to use when rendering. Remember that only the emissive channel is able to be rendered as no lighting is performed when rendering to the Canvas.
		/// </param>
		/// <param name="ScreenPosition">
		/// Screen space position to render the texture.
		/// </param>
		/// <param name="ScreenSize">
		/// Screen space size to render the texture.
		/// </param>
		/// <param name="CoordinatePosition">
		/// Normalized UV starting coordinate to use when rendering the texture.
		/// </param>
		/// <param name="CoordinateSize">
		/// Normalized UV size coordinate to use when rendering the texture.
		/// </param>
		/// <param name="Rotation">
		/// Rotation, in degrees, to render the texture.
		/// </param>
		/// <param name="PivotPoint">
		/// Normalized pivot point to use when rotating the texture.
		/// </param>
		public virtual void K2_DrawMaterial(UMaterialInterface RenderMaterial, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize = null, float Rotation = 0.000000f, FVector2D PivotPoint = null)
		{
			unsafe
			{
				CoordinateSize ??= new FVector2D(1.000000, 1.000000);

				PivotPoint ??= new FVector2D(0.500000, 0.500000);

				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = RenderMaterial?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScreenSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = CoordinatePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = CoordinateSize?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Rotation;

				*(nint*)(__InBuffer + 44) = PivotPoint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawMaterial, __InBuffer);
			}
		}

		/// <param name="ScreenPositionA">
		/// Starting position of the line in screen space.
		/// </param>
		/// <param name="ScreenPositionB">
		/// Ending position of the line in screen space.
		/// </param>
		/// <param name="Thickness">
		/// How many pixels thick this line should be.
		/// </param>
		/// <param name="RenderColor">
		/// Color to render the line.
		/// </param>
		public virtual void K2_DrawLine(FVector2D ScreenPositionA = null, FVector2D ScreenPositionB = null, float Thickness = 1.000000f, FLinearColor RenderColor = null)
		{
			unsafe
			{
				ScreenPositionA ??= new FVector2D();

				ScreenPositionB ??= new FVector2D();

				RenderColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = ScreenPositionA?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenPositionB?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Thickness;

				*(nint*)(__InBuffer + 20) = RenderColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawLine, __InBuffer);
			}
		}

		/// <param name="ScreenPosition">
		/// Screen space position to render the text.
		/// </param>
		/// <param name="ScreenSize">
		/// Screen space size to render the texture.
		/// </param>
		/// <param name="Thickness">
		/// How many pixels thick the box lines should be.
		/// </param>
		public virtual void K2_DrawBox(FVector2D ScreenPosition, FVector2D ScreenSize, float Thickness = 1.000000f, FLinearColor RenderColor = null)
		{
			unsafe
			{
				RenderColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenSize?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Thickness;

				*(nint*)(__InBuffer + 20) = RenderColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawBox, __InBuffer);
			}
		}

		/// <param name="BorderTexture">
		/// Texture to use for border.
		/// </param>
		/// <param name="BackgroundTexture">
		/// Texture to use for border background.
		/// </param>
		/// <param name="LeftBorderTexture">
		/// Texture to use for the tiling left border.
		/// </param>
		/// <param name="RightBorderTexture">
		/// Texture to use for the tiling right border.
		/// </param>
		/// <param name="TopBorderTexture">
		/// Texture to use for the tiling top border.
		/// </param>
		/// <param name="BottomBorderTexture">
		/// Texture to use for the tiling bottom border.
		/// </param>
		/// <param name="ScreenPosition">
		/// Screen space position to render the texture.
		/// </param>
		/// <param name="ScreenSize">
		/// Screen space size to render the texture.
		/// </param>
		/// <param name="CoordinatePosition">
		/// Normalized UV starting coordinate to use when rendering the border texture.
		/// </param>
		/// <param name="CoordinateSize">
		/// Normalized UV size coordinate to use when rendering the border texture.
		/// </param>
		/// <param name="RenderColor">
		/// Color to tint the border.
		/// </param>
		/// <param name="BorderScale">
		/// Scale of the border.
		/// </param>
		/// <param name="BackgroundScale">
		/// Scale of the background.
		/// </param>
		/// <param name="Rotation">
		/// Rotation, in degrees, to render the texture.
		/// </param>
		/// <param name="PivotPoint">
		/// Normalized pivot point to use when rotating the texture.
		/// </param>
		/// <param name="CornerSize">
		/// Frame corner size in percent of frame texture (should be < 0.5f).
		/// </param>
		public virtual void K2_DrawBorder(UTexture BorderTexture, UTexture BackgroundTexture, UTexture LeftBorderTexture, UTexture RightBorderTexture, UTexture TopBorderTexture, UTexture BottomBorderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize = null, FLinearColor RenderColor = null, FVector2D BorderScale = null, FVector2D BackgroundScale = null, float Rotation = 0.000000f, FVector2D PivotPoint = null, FVector2D CornerSize = null)
		{
			unsafe
			{
				CoordinateSize ??= new FVector2D(1.000000, 1.000000);

				RenderColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				BorderScale ??= new FVector2D(0.100000, 0.100000);

				BackgroundScale ??= new FVector2D(0.100000, 0.100000);

				PivotPoint ??= new FVector2D(0.500000, 0.500000);

				CornerSize ??= new FVector2D();

				var __InBuffer = stackalloc byte[124];

				*(nint*)(__InBuffer) = BorderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BackgroundTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LeftBorderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = RightBorderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = TopBorderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = BottomBorderTexture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = ScreenSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 64) = CoordinatePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 72) = CoordinateSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 80) = RenderColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 88) = BorderScale?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 96) = BackgroundScale?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 104) = Rotation;

				*(nint*)(__InBuffer + 108) = PivotPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 116) = CornerSize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __K2_DrawBorder, __InBuffer);
			}
		}

		/// <param name="ScreenPosition">
		/// Screen space position to deproject to the World.
		/// </param>
		/// <param name="WorldOrigin">
		/// Vector which is the world position of the screen space position.
		/// </param>
		/// <param name="WorldDirection">
		/// Vector which can be used in a trace to determine what is "behind" the screen space position. Useful for object picking.
		/// </param>
		public virtual void K2_Deproject(FVector2D ScreenPosition, ref FVector WorldOrigin, ref FVector WorldDirection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ScreenPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldOrigin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_Deproject, __InBuffer, __OutBuffer);

				WorldOrigin = *(FVector*)(__OutBuffer);

				WorldDirection = *(FVector*)(__OutBuffer + 8);

			}
		}

		private static uint __OrgX = 0;

		private static uint __OrgY = 0;

		private static uint __ClipX = 0;

		private static uint __ClipY = 0;

		private static uint __DrawColor = 0;

		private static uint __bCenterX = 0;

		private static uint __bCenterY = 0;

		private static uint __bNoSmooth = 0;

		private static uint __SizeX = 0;

		private static uint __SizeY = 0;

		private static uint __ColorModulate = 0;

		private static uint __DefaultTexture = 0;

		private static uint __GradientTexture0 = 0;

		private static uint __ReporterGraph = 0;

		private static uint __K2_TextSize = 0;

		private static uint __K2_StrLen = 0;

		private static uint __K2_Project = 0;

		private static uint __K2_DrawTriangle = 0;

		private static uint __K2_DrawTexture = 0;

		private static uint __K2_DrawText = 0;

		private static uint __K2_DrawPolygon = 0;

		private static uint __K2_DrawMaterialTriangle = 0;

		private static uint __K2_DrawMaterial = 0;

		private static uint __K2_DrawLine = 0;

		private static uint __K2_DrawBox = 0;

		private static uint __K2_DrawBorder = 0;

		private static uint __K2_Deproject = 0;
	}
}