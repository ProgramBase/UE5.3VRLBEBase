using Script.CoreUObject;
using Script.Library;

namespace Script.MaterialEditor
{
	[PathName("/Script/MaterialEditor.PreviewBackgroundSettings")]
	public partial class FPreviewBackgroundSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MaterialEditor.PreviewBackgroundSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPreviewBackgroundSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPreviewBackgroundSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPreviewBackgroundSettings A, FPreviewBackgroundSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPreviewBackgroundSettings A, FPreviewBackgroundSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPreviewBackgroundSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bShowBorder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowBorder, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowBorder, __InBuffer);
				}
			}
		}

		public FColor BorderColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BorderColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BorderColor, __InBuffer);
				}
			}
		}

		public EBackgroundType BackgroundType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundType, __ReturnBuffer);

					return *(EBackgroundType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundType, __InBuffer);
				}
			}
		}

		public FColor BackgroundColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BackgroundColor, __InBuffer);
				}
			}
		}

		public FCheckerboardSettings Checkerboard
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Checkerboard, __ReturnBuffer);

					return *(FCheckerboardSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Checkerboard, __InBuffer);
				}
			}
		}

		private static uint __bShowBorder = 0;

		private static uint __BorderColor = 0;

		private static uint __BackgroundType = 0;

		private static uint __BackgroundColor = 0;

		private static uint __Checkerboard = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}