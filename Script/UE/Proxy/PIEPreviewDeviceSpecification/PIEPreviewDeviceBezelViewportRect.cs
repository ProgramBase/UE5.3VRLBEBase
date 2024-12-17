using Script.CoreUObject;
using Script.Library;

namespace Script.PIEPreviewDeviceSpecification
{
	[PathName("/Script/PIEPreviewDeviceSpecification.PIEPreviewDeviceBezelViewportRect")]
	public partial class FPIEPreviewDeviceBezelViewportRect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PIEPreviewDeviceSpecification.PIEPreviewDeviceBezelViewportRect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPIEPreviewDeviceBezelViewportRect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPIEPreviewDeviceBezelViewportRect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPIEPreviewDeviceBezelViewportRect A, FPIEPreviewDeviceBezelViewportRect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPIEPreviewDeviceBezelViewportRect A, FPIEPreviewDeviceBezelViewportRect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPIEPreviewDeviceBezelViewportRect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int X
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __X, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __X, __InBuffer);
				}
			}
		}

		public int Y
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Y, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Y, __InBuffer);
				}
			}
		}

		public int Width
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Width, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Width, __InBuffer);
				}
			}
		}

		public int Height
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Height, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Height, __InBuffer);
				}
			}
		}

		private static uint __X = 0;

		private static uint __Y = 0;

		private static uint __Width = 0;

		private static uint __Height = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}